using System;
using System.Numerics;
using ImGuiNET;

namespace BossNotes
{
    public class UI : IDisposable
    {
        private readonly Configuration _configuration;

        private readonly Expansion[] _expansions =
        {
            new ARR.ARR(),
            new Stormblood.Stormblood()
        };

        private readonly string[] _types =
        {
            "Dungeons",
            "Trials",
            "Raids"
        };

        private Instance _selectedInstance;
        private int _selectedInstanceIndex;

        private int _selectedType;

        private bool _visible;

        public UI(Configuration configuration)
        {
            _configuration = configuration;
        }

        public bool Visible
        {
            get => _visible;
            set => _visible = value;
        }

        public void Dispose()
        {
        }

        public void Draw()
        {
            DrawNotesWindows();
        }

        public void DrawNotesWindows()
        {
            if (!_visible)
                return;

            ImGui.SetNextWindowSize(new Vector2(400, 600) * ImGui.GetIO().FontGlobalScale, ImGuiCond.FirstUseEver);

            if (ImGui.Begin("BossNotes", ref _visible, ImGuiWindowFlags.None))
            {
                if (ImGui.BeginCombo("expansion combo", _expansions[_configuration.SelectedExpansion].Name))
                {
                    for (var i = 0; i < _expansions.Length; i++)
                    {
                        var selected = i == _configuration.SelectedExpansion;
                        if (ImGui.Selectable(_expansions[i].Name, selected))
                        {
                            _selectedInstance = _expansions[i].Dungeons[0];
                            _configuration.SelectedExpansion = i;
                        }

                        if (selected)
                            ImGui.SetItemDefaultFocus();
                    }

                    ImGui.EndCombo();
                }

                ImGui.SameLine();
                if (ImGui.BeginCombo("type combo", _types[_selectedType]))
                {
                    for (var i = 0; i < _types.Length; i++)
                    {
                        var selected = i == _selectedType;
                        if (ImGui.Selectable(_types[i], selected))
                        {
                            _selectedInstance = i switch
                            {
                                0 => _expansions[_configuration.SelectedExpansion].Dungeons[0],
                                1 => _expansions[_configuration.SelectedExpansion].Trials[0],
                                2 => _expansions[_configuration.SelectedExpansion].Raids[0],
                                _ => throw new ArgumentOutOfRangeException()
                            };
                            _selectedType = i;
                        }

                        if (selected)
                            ImGui.SetItemDefaultFocus();
                    }

                    ImGui.EndCombo();
                }

                var list = _selectedType switch
                {
                    0 => _expansions[_configuration.SelectedExpansion].Dungeons,
                    1 => _expansions[_configuration.SelectedExpansion].Trials,
                    2 => _expansions[_configuration.SelectedExpansion].Raids,
                    _ => throw new ArgumentOutOfRangeException()
                };

                ImGui.SameLine();
                if (ImGui.BeginCombo("instance combo", _selectedInstance.Name))
                {
                    for (var i = 0; i < list.Length; i++)
                    {
                        var selected = i == _selectedInstanceIndex;
                        if (ImGui.Selectable(list[i].Name, selected))
                        {
                            _selectedInstance = list[i];
                            _selectedInstanceIndex = i;
                        }

                        if (selected)
                            ImGui.SetItemDefaultFocus();
                    }

                    ImGui.EndCombo();
                }
            }

            ImGui.End();
        }
    }
}