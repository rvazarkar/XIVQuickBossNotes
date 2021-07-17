using System;
using Dalamud.Configuration;
using Dalamud.Game.Text;
using Dalamud.Plugin;

namespace BossNotes
{
    public class Configuration : IPluginConfiguration
    {
        [NonSerialized] private DalamudPluginInterface _pluginInterface;

        public int SelectedExpansionIndex { get; set; } = 0;
        public int SelectedTypeIndex { get; set; } = 0;
        public int SelectedInstanceIndex { get; set; } = 0;
        public int SelectedBossIndex { get; set; } = 0;

        public int SelectedChatIndex { get; set; } = 0;

        public bool AutoSelectChat { get; set; } = true;

        public int Version { get; set; } = 0;

        public void Initialize(DalamudPluginInterface pluginInterface)
        {
            _pluginInterface = pluginInterface;
        }

        public void Save()
        {
            _pluginInterface.SavePluginConfig(this);
        }

        public void SetSelected(DungeonSelectionIndex idx)
        {
            SelectedExpansionIndex = idx.SelectedExpansion;
            SelectedTypeIndex = idx.SelectedType;
            SelectedInstanceIndex = idx.SelectedInstance;
        }
    }
}