using System.Collections.Generic;
using System.Reflection;
using Dalamud.Game.Command;
using Dalamud.Plugin;

namespace BossNotes
{
    public class BossNotesPlugin : IDalamudPlugin
    {
        private const string Command = "/bnotes";

        private readonly Expansion[] _expansions =
        {
            new ARR.ARR(),
            new Heavensward.Heavensward(),
            new Stormblood.Stormblood(),
            new Shadowbringers.Shadowbringers()
        };

        private Configuration _configuration;

        private DalamudPluginInterface _pluginInterface;
        private UI _ui;

        private Dictionary<ushort, DungeonSelectionIndex> _zoneMap;

        public string AssemblyLocation { get; set; } = Assembly.GetExecutingAssembly().Location;

        public void Dispose()
        {
            _ui.Dispose();
            _pluginInterface.CommandManager.RemoveHandler(Command);
            _pluginInterface.ClientState.TerritoryChanged -= OnTerritoryChanged;
            _pluginInterface.Dispose();
        }

        public void Initialize(DalamudPluginInterface pluginInterface)
        {
            _pluginInterface = pluginInterface;
            _configuration = pluginInterface.GetPluginConfig() as Configuration ?? new Configuration();
            _configuration.Initialize(_pluginInterface);

            BuildZoneMap();

            _ui = new UI(_configuration, _pluginInterface, _expansions);

            _pluginInterface.CommandManager.AddHandler(Command, new CommandInfo(OnCommand)
            {
                HelpMessage = "Displays quick notes for bosses and lets you print quick strategies to chat."
            });

            _pluginInterface.UiBuilder.OnBuildUi += DrawUI;
            _pluginInterface.ClientState.TerritoryChanged += OnTerritoryChanged;
        }

        public string Name => "Boss Notes";

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
                    _zoneMap.Add(_expansions[i].Dungeons[j].ZoneID, new DungeonSelectionIndex(i, 0, j));

                for (var j = 0; j < _expansions[i].Trials.Length; j++)
                    _zoneMap.Add(_expansions[i].Trials[j].ZoneID, new DungeonSelectionIndex(i, 1, j));

                for (var j = 0; j < _expansions[i].Raids.Length; j++)
                    _zoneMap.Add(_expansions[i].Raids[j].ZoneID, new DungeonSelectionIndex(i, 2, j));
            }
        }

        private void OnCommand(string command, string args)
        {
            _ui.Visible = !_ui.Visible;
        }

        private void DrawUI()
        {
            _ui.Draw();
        }
    }
}