using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using BossNotes.ENG.ARR;
using BossNotes.ENG.Heavensward;
using BossNotes.ENG.Shadowbringers;
using BossNotes.ENG.Stormblood;
using Dalamud;
using Dalamud.Game;
using Dalamud.Game.ClientState;
using Dalamud.Game.ClientState.Objects;
using Dalamud.Game.Command;
using Dalamud.Game.Gui;
using Dalamud.IoC;
using Dalamud.Logging;
using Dalamud.Plugin;

namespace BossNotes
{
    public class BossNotesPlugin : IDalamudPlugin, IDisposable
    {
        private const string Command = "/bnotes";
        private const string ReloadCommand = "/bnotesreload";

        private Configuration _configuration;

        private Expansion[] _expansions;

        private readonly DalamudPluginInterface _pluginInterface;
        private readonly CommandManager _commandManager;
        private readonly ClientState _clientState;
        private UI _ui;

        private Dictionary<ushort, DungeonSelectionIndex> _zoneMap;

        public BossNotesPlugin(
            [RequiredVersion("1.0")]DalamudPluginInterface pluginInterface, 
            [RequiredVersion("1.0")] CommandManager commandManager, 
            [RequiredVersion("1.0")] ClientState clientState,
            [RequiredVersion("1.0")] GameGui gameGui,
            [RequiredVersion("1.0")] SigScanner sigScanner,
            [RequiredVersion("1.0")] ObjectTable objectTable)
        {
            _pluginInterface = pluginInterface;
            _commandManager = commandManager;
            _clientState = clientState;
            _configuration = pluginInterface.GetPluginConfig() as Configuration ?? new Configuration();
            _configuration.Initialize(_pluginInterface);
            
            _expansions = LoadContent(AssemblyLocation);

            BuildZoneMap();

            _ui = new UI(_configuration, _expansions, sigScanner, clientState, gameGui, objectTable);
            _ui.Initialize();
            
            _commandManager.AddHandler(Command, new CommandInfo(OnCommand)
            {
                HelpMessage = "Displays quick notes for bosses and lets you print quick strategies to chat."
            });

            _commandManager.AddHandler(ReloadCommand, new CommandInfo(OnReloadCommand)
            {
                HelpMessage = "Reloads boss strats."
            });
            
            _pluginInterface.UiBuilder.OpenConfigUi += DrawUI;
            _clientState.TerritoryChanged += OnTerritoryChanged;
        }
        
        public string AssemblyLocation { get; set; } = Assembly.GetExecutingAssembly().Location;
        public void Dispose()
        {
            _ui.Dispose();
            _commandManager.RemoveHandler(Command);
            _commandManager.RemoveHandler(ReloadCommand);
            _clientState.TerritoryChanged -= OnTerritoryChanged;
            _pluginInterface.Dispose();
        }

        public string Name => "Boss Notes";

        private Expansion[] LoadContent(string assemblyLocation)
        {
            var lang = _clientState.ClientLanguage;
            var folder = Path.GetDirectoryName(assemblyLocation);
            var langFolder = lang switch
            {
                ClientLanguage.Japanese => "JPN",
                ClientLanguage.English => "ENG",
                ClientLanguage.German => "GER",
                ClientLanguage.French => "FR",
                _ => throw new ArgumentOutOfRangeException(nameof(lang), lang, null)
            };

            var basePath = Path.Combine(folder, langFolder);
            return new Expansion[]
            {
                new ARR(basePath),
                new Heavensward(basePath),
                new Stormblood(basePath),
                new Shadowbringers(basePath)
            };
        }

        private void OnTerritoryChanged(object sender, ushort id)
        {
            if (!_configuration.AutoSwapDungeon) return;

            if (!_zoneMap.ContainsKey(id)) return;
            _ui.SetSelected(_zoneMap[id]);
            _configuration.SetSelected(_zoneMap[id]);
            _ui.Visible = true;
        }

        private void BuildZoneMap()
        {
            _zoneMap = new Dictionary<ushort, DungeonSelectionIndex>();

            for (var i = 0; i < _expansions.Length; i++)
            {
                for (var j = 0; j < _expansions[i].Dungeons.Length; j++)
                    InsertZoneMap(_expansions[i].Dungeons[j], new DungeonSelectionIndex(i, 0, j));

                for (var j = 0; j < _expansions[i].Trials.Length; j++)
                    InsertZoneMap(_expansions[i].Trials[j], new DungeonSelectionIndex(i, 1, j));

                for (var j = 0; j < _expansions[i].HighEndTrials.Length; j++)
                    InsertZoneMap(_expansions[i].HighEndTrials[j], new DungeonSelectionIndex(i, 2, j));

                for (var j = 0; j < _expansions[i].Raids.Length; j++)
                    InsertZoneMap(_expansions[i].Raids[j], new DungeonSelectionIndex(i, 3, j));

                for (var j = 0; j < _expansions[i].AllianceRaids.Length; j++)
                    InsertZoneMap(_expansions[i].AllianceRaids[j], new DungeonSelectionIndex(i, 4, j));
            }
        }

        private void InsertZoneMap(Instance i, DungeonSelectionIndex idx)
        {
            try
            {
                _zoneMap.Add(i.ZoneID, idx);
            }
            catch
            {
                PluginLog.LogError($"Error inserting {i.Name}");
            }
        }

        private void OnCommand(string command, string args)
        {
            _ui.Visible = !_ui.Visible;
        }

        private void OnReloadCommand(string command, string args)
        {
            _expansions = LoadContent(AssemblyLocation);
            BuildZoneMap();
        }

        private void DrawUI()
        {
            _ui.Draw();
        }
    }
}