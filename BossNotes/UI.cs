using System;
using System.Linq;
using System.Numerics;
using Dalamud.Game.ClientState;
using Dalamud.Game.ClientState.Actors;
using Dalamud.Game.Text;
using Dalamud.Plugin;
using ImGuiNET;
using XivCommon;

namespace BossNotes
{
    public class UI : IDisposable
    {
        private readonly Configuration _configuration;

        private readonly Expansion[] _expansions;

        private readonly ChatChannel[] _chatChannels = {
            new ChatChannel("Say", "say"),
            new ChatChannel("Yell", "yell"),
            new ChatChannel("Shout", "shout"),
            new ChatChannel("Party", "party"),
            new ChatChannel("Alliance", "alliance"),
            new ChatChannel("Free Company", "fc"),
            new ChatChannel("Linkshell 1", "ls1"),
            new ChatChannel("Linkshell 2", "ls2"),
            new ChatChannel("Linkshell 3", "ls3"),
            new ChatChannel("Linkshell 4", "ls4"),
            new ChatChannel("Linkshell 5", "ls5"),
            new ChatChannel("Linkshell 6", "ls6"),
            new ChatChannel("Linkshell 7", "ls7"),
            new ChatChannel("Linkshell 8", "ls8"),
        };

        private readonly string[] _types =
        {
            "Dungeons",
            "Trials",
            "Raids"
        };

        private readonly XivCommonBase _xivBase;
        private readonly DalamudPluginInterface _pluginInterface;

        private Instance _selectedInstance;
        private bool _autoSelectChat;

        private bool _visible;

        public UI(Configuration configuration, DalamudPluginInterface pluginInterface, Expansion[] expansions)
        {
            _configuration = configuration;
            _autoSelectChat = configuration.AutoSelectChat;
            _expansions = expansions;
            _pluginInterface = pluginInterface;
            _xivBase = new XivCommonBase(pluginInterface);

            _selectedInstance = _expansions[_configuration.SelectedExpansionIndex]
                .Dungeons[_configuration.SelectedInstanceIndex];
        }

        //Taken from https://github.com/karashiiro/NeatNoter/blob/main/NeatNoter/NeatNoterUI.cs
        private static float InverseFontScale => 1 / ImGui.GetIO().FontGlobalScale;
        private static float WindowSizeY => ImGui.GetWindowSize().Y * ImGui.GetIO().FontGlobalScale;
        private static float ElementSizeX => ImGui.GetWindowSize().X - 16 * InverseFontScale;

        public bool Visible
        {
            get => _visible;
            set => _visible = value;
        }

        public void Dispose()
        {
            _configuration.AutoSelectChat = _autoSelectChat;
            _configuration.Save();
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

            if (ImGui.Begin("BossNotes", ref _visible, ImGuiWindowFlags.None))
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
                                2 => _expansions[_configuration.SelectedExpansionIndex].Raids[0],
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
                    2 => _expansions[_configuration.SelectedExpansionIndex].Raids,
                    _ => throw new ArgumentOutOfRangeException()
                };
                // ImGui.PopItemWidth();
                // ImGui.PushItemWidth(ImGui.GetContentRegionAvail().X);
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

                var body = _selectedInstance.Bosses[_configuration.SelectedBossIndex].InDepthStrategy;
                ImGui.TextWrapped(body);

                ImGui.SetCursorPosX(10);
                ImGui.SetCursorPosY(WindowSizeY - 30);

                ImGui.Checkbox("Auto Select Chat", ref _autoSelectChat);

                if (!_autoSelectChat)
                {
                    ImGui.SameLine();
                    if (ImGui.BeginCombo("##BossNotes Chat select", _chatChannels[_configuration.SelectedChatIndex].DisplayName))
                    {
                        for (var i = 0; i < _chatChannels.Length; i++)
                        {
                            var selected = i == _configuration.SelectedChatIndex;
                        
                            if (ImGui.Selectable(_chatChannels[i].DisplayName,  selected))
                            {
                                _configuration.SelectedChatIndex = i;
                            }
                        
                            if (selected)
                                ImGui.SetItemDefaultFocus();
                        }
                    
                        ImGui.EndCombo();
                    }
                }

                ImGui.SameLine();
                if (ImGui.Button("Print Quick Strat"))
                {
                    ChatChannel channel;
                    if (_autoSelectChat)
                    {
                        if ((_pluginInterface.ClientState.LocalPlayer.StatusFlags & StatusFlags.AllianceMember) != 0)
                        {
                            channel = _chatChannels[4];
                        }else if ((_pluginInterface.ClientState.LocalPlayer.StatusFlags & StatusFlags.PartyMember) != 0)
                        {
                            channel = _chatChannels[3];
                        }
                        else
                        {
                            channel = _chatChannels[0];
                        }
                    }
                    else
                    {
                        channel = _chatChannels[_configuration.SelectedChatIndex];
                        
                    }
                    
                    var baseMessage =
                        $"{_selectedInstance.Bosses[_configuration.SelectedBossIndex].Name}: {_selectedInstance.Bosses[_configuration.SelectedBossIndex].QuickStrategy}";
                    _xivBase.Functions.Chat.SendMessage(channel.FormatMessage(baseMessage));
                }

                ImGui.End();
            }
        }
    }
}