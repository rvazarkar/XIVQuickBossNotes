using System;
using ImGuiNET;
using ImGuiScene;
using System.Numerics;

namespace BossNotes
{
    public class UI : IDisposable
    {
        private readonly Configuration _configuration;
        private readonly string[] _expansions = {"A Realm Reborn", "Heavensward", "Shadowbringers", "Stormblood"};

        private bool _visible = false;
        public bool Visible
        {
            get => _visible;
            set => _visible = value;
        }

        public UI(Configuration configuration)
        {
            _configuration = configuration;
        }

        public void DrawNotesWindows()
        {
            if (!_visible)
                return;
            
            ImGui.SetNextWindowSize(new Vector2(400, 600) * ImGui.GetIO().FontGlobalScale, ImGuiCond.FirstUseEver);
            ImGui.Begin("BossNotes", ImGuiWindowFlags.None);

            if (ImGui.BeginTabBar("BossNotesTabBar", ImGuiTabBarFlags.NoTooltip))
            {
                if (ImGui.BeginCombo("expansion combo", _expansions[_configuration.SelectedExpansion]))
                {
                    for (var i = 0; i < _expansions.Length; i++)
                    {
                        var selected = i == _configuration.SelectedExpansion;
                        if (ImGui.Selectable(_expansions[i], selected))
                        {
                            _configuration.SelectedExpansion = i;
                        }

                        if (selected)
                            ImGui.SetItemDefaultFocus();
                    }
                    ImGui.EndCombo();
                }
            }
        }
        
        public void Dispose()
        {
        }
    }
}