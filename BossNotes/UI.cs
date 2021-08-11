using System;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using BossNotes.Internal;
using Dalamud.Game.ClientState.Actors;
using Dalamud.Plugin;
using ImGuiNET;
using XivCommon;

namespace BossNotes
{
    public class UI : IDisposable
    {
        private static IntPtr _raptureShellModule = IntPtr.Zero;
        private static ExecuteMacroDelegate _executeMacro;

        private readonly ChatChannel[] _chatChannels =
        {
            new("Say", "say"),
            new("Yell", "yell"),
            new("Shout", "shout"),
            new("Party", "party"),
            new("Alliance", "alliance"),
            new("Free Company", "fc"),
            new("Linkshell 1", "ls1"),
            new("Linkshell 2", "ls2"),
            new("Linkshell 3", "ls3"),
            new("Linkshell 4", "ls4"),
            new("Linkshell 5", "ls5"),
            new("Linkshell 6", "ls6"),
            new("Linkshell 7", "ls7"),
            new("Linkshell 8", "ls8")
        };

        private readonly Configuration _configuration;

        private readonly Expansion[] _expansions;
        private readonly DalamudPluginInterface _pluginInterface;

        private readonly string[] _types =
        {
            "Dungeons",
            "Trials",
            "High-End Trials",
            "Raids",
            "Alliance Raids"
        };

        private readonly XivCommonBase _xivBase;
        private bool _autoSelectChat;
        private bool _autoSwapDungeons;

        private Instance _selectedInstance;
        private bool _showDetails;

        private bool _visible;

        public UI(Configuration configuration, DalamudPluginInterface pluginInterface, Expansion[] expansions)
        {
            _configuration = configuration;
            _autoSelectChat = configuration.AutoSelectChat;
            _autoSwapDungeons = configuration.AutoSwapDungeon;
            _showDetails = configuration.ShowDetails;
            _expansions = expansions;
            _pluginInterface = pluginInterface;
            _xivBase = new XivCommonBase(pluginInterface);
            _pluginInterface.Framework.Gui.GetUIModule();


            _selectedInstance = _expansions[_configuration.SelectedExpansionIndex]
                .Dungeons[_configuration.SelectedInstanceIndex];
        }

        public bool Visible
        {
            get => _visible;
            set => _visible = value;
        }

        public void Dispose()
        {
            _configuration.AutoSelectChat = _autoSelectChat;
            _configuration.AutoSwapDungeon = _autoSwapDungeons;
            _configuration.ShowDetails = _showDetails;
            _configuration.Save();
        }

        public unsafe void Initialize()
        {
            var uiModule = _pluginInterface.Framework.Gui.GetUIModule();
            var vtbl = (IntPtr*) (*(IntPtr*) uiModule);
            var getRaptureShellModule = Marshal.GetDelegateForFunctionPointer<GetModuleDelegate>(*(vtbl + 9));
            _raptureShellModule = getRaptureShellModule(uiModule);
            _executeMacro = Marshal.GetDelegateForFunctionPointer<ExecuteMacroDelegate>(
                _pluginInterface.TargetModuleScanner.ScanText("E8 ?? ?? ?? ?? E9 ?? ?? ?? ?? 48 8D 4D 28"));
        }

        public void SetSelected(DungeonSelectionIndex idx)
        {
            _selectedInstance = idx.SelectedType switch
            {
                0 => _expansions[idx.SelectedExpansion].Dungeons[idx.SelectedInstance],
                1 => _expansions[idx.SelectedExpansion].Trials[idx.SelectedInstance],
                2 => _expansions[idx.SelectedExpansion].HighEndTrials[idx.SelectedInstance],
                3 => _expansions[idx.SelectedExpansion].Raids[idx.SelectedInstance],
                4 => _expansions[idx.SelectedExpansion].AllianceRaids[idx.SelectedInstance],
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        public void Draw()
        {
            DrawNotesWindows();
        }

        public void DrawNotesWindows()
        {
            if (!_visible)
                return;

            ImGui.SetNextWindowSize(new Vector2(600, 400) * ImGui.GetIO().FontGlobalScale, ImGuiCond.FirstUseEver);
            var avail = ImGui.GetContentRegionAvail().X;

            if (ImGui.Begin("BossNotes", ref _visible, ImGuiWindowFlags.NoCollapse | ImGuiWindowFlags.AlwaysAutoResize))
            {
                ImGui.PushItemWidth(avail / 3);
                if (ImGui.BeginCombo("##expansion", _expansions[_configuration.SelectedExpansionIndex].Name,
                    ImGuiComboFlags.None))
                {
                    for (var i = 0; i < _expansions.Length; i++)
                    {
                        var selected = i == _configuration.SelectedExpansionIndex;
                        if (ImGui.Selectable(_expansions[i].Name, selected))
                        {
                            _selectedInstance = _expansions[i].Dungeons[0];
                            _configuration.SelectedExpansionIndex = i;
                        }

                        if (selected)
                            ImGui.SetItemDefaultFocus();
                    }

                    ImGui.EndCombo();
                }

                ImGui.SameLine();
                if (ImGui.BeginCombo("##type", _types[_configuration.SelectedTypeIndex]))
                {
                    for (var i = 0; i < _types.Length; i++)
                    {
                        var selected = i == _configuration.SelectedTypeIndex;
                        if (ImGui.Selectable(_types[i], selected))
                        {
                            _configuration.SelectedBossIndex = 0;
                            _selectedInstance = i switch
                            {
                                0 => _expansions[_configuration.SelectedExpansionIndex].Dungeons[0],
                                1 => _expansions[_configuration.SelectedExpansionIndex].Trials[0],
                                2 => _expansions[_configuration.SelectedExpansionIndex].HighEndTrials[0],
                                3 => _expansions[_configuration.SelectedExpansionIndex].Raids[0],
                                4 => _expansions[_configuration.SelectedExpansionIndex].AllianceRaids[0],
                                _ => throw new ArgumentOutOfRangeException()
                            };
                            _configuration.SelectedTypeIndex = i;
                        }

                        if (selected)
                            ImGui.SetItemDefaultFocus();
                    }

                    ImGui.EndCombo();
                }

                var list = _configuration.SelectedTypeIndex switch
                {
                    0 => _expansions[_configuration.SelectedExpansionIndex].Dungeons,
                    1 => _expansions[_configuration.SelectedExpansionIndex].Trials,
                    2 => _expansions[_configuration.SelectedExpansionIndex].HighEndTrials,
                    3 => _expansions[_configuration.SelectedExpansionIndex].Raids,
                    4 => _expansions[_configuration.SelectedExpansionIndex].AllianceRaids,
                    _ => throw new ArgumentOutOfRangeException()
                };

                ImGui.SameLine();
                if (ImGui.BeginCombo("##selectedinstance", _selectedInstance.Name))
                {
                    for (var i = 0; i < list.Length; i++)
                    {
                        var selected = i == _configuration.SelectedInstanceIndex;
                        if (ImGui.Selectable(list[i].Name, selected))
                        {
                            _configuration.SelectedBossIndex = 0;
                            _selectedInstance = list[i];
                            _configuration.SelectedInstanceIndex = i;
                        }

                        if (selected)
                            ImGui.SetItemDefaultFocus();
                    }

                    ImGui.EndCombo();
                }

                ImGui.SameLine();
                if (ImGui.Checkbox("Auto Pick", ref _autoSwapDungeons))
                    _configuration.AutoSwapDungeon = _autoSwapDungeons;

                ImGui.SameLine();
                if (ImGui.Checkbox("Show Details", ref _showDetails))
                    _configuration.ShowDetails = _showDetails;

                if (_showDetails)
                {
                    if (ImGui.BeginTabBar("BossNotes Tab Bar", ImGuiTabBarFlags.NoTooltip))
                    {
                        for (var i = 0; i < _selectedInstance.Bosses.Length; i++)
                            if (ImGui.BeginTabItem(_selectedInstance.Bosses[i].Name))
                            {
                                _configuration.SelectedBossIndex = i;
                                ImGui.EndTabItem();
                            }

                        ImGui.EndTabBar();
                    }

                    ImGui.BeginChild("#BossNotesDetailSection", new Vector2(600, 300), false);
                    var body = _selectedInstance.Bosses[_configuration.SelectedBossIndex].InDepthStrategy;
                    ImGui.TextWrapped(body);
                    ImGui.EndChild();
                }

                ImGui.Checkbox("Auto Select Chat", ref _autoSelectChat);

                if (!_autoSelectChat)
                {
                    ImGui.SameLine();
                    if (ImGui.BeginCombo("##BossNotes Chat select",
                        _chatChannels[_configuration.SelectedChatIndex].DisplayName))
                    {
                        for (var i = 0; i < _chatChannels.Length; i++)
                        {
                            var selected = i == _configuration.SelectedChatIndex;

                            if (ImGui.Selectable(_chatChannels[i].DisplayName, selected))
                                _configuration.SelectedChatIndex = i;

                            if (selected)
                                ImGui.SetItemDefaultFocus();
                        }

                        ImGui.EndCombo();
                    }
                }

                ImGui.SameLine();
                ImGui.Text("Share Strat:");

                foreach (var phase in _selectedInstance.Bosses)
                {
                    ImGui.SameLine();
                    if (ImGui.Button($"{phase.Name}"))
                    {
                        var baseMessage =
                            $"★{phase.Name}★: {phase.QuickStrategy}";
                        OutputChat(baseMessage);
                    }
                }

                ImGui.End();
            }
        }

        private void OutputChat(string baseMessage)
        {
            ChatChannel channel;
            if (_autoSelectChat)
            {
                var player = _pluginInterface.ClientState.LocalPlayer;

                if (player == null)
                {
                    channel = _chatChannels[0];
                }
                else
                {
                    if ((player.StatusFlags & StatusFlags.AllianceMember) != 0)
                        channel = _chatChannels[4];
                    else if ((player.StatusFlags & StatusFlags.PartyMember) != 0)
                        channel = _chatChannels[3];
                    else
                        channel = _chatChannels[0];
                }
            }
            else
            {
                channel = _chatChannels[_configuration.SelectedChatIndex];
            }

            var commands = baseMessage.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None).Select(x => channel.FormatMessage(x)).ToList();

            var macroPtr = IntPtr.Zero;
            try
            {
                macroPtr = Marshal.AllocHGlobal(Macro.size);
                using var macro = new Macro(macroPtr, string.Empty, commands);
                Marshal.StructureToPtr(macro, macroPtr, false);
                _executeMacro.Invoke(_raptureShellModule, macroPtr);
            }
            catch
            {
                //pass
            }
            finally
            {
                if (macroPtr != IntPtr.Zero) Marshal.FreeHGlobal(macroPtr);
            }
        }

        private delegate void ExecuteMacroDelegate(IntPtr raptureShellModule, IntPtr macro);

        private delegate IntPtr GetModuleDelegate(IntPtr basePtr);
    }
}