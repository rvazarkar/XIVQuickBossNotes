using System;
using Dalamud.Configuration;
using Dalamud.Plugin;

namespace BossNotes
{
    public class Configuration : IPluginConfiguration
    {
        [NonSerialized] private DalamudPluginInterface _pluginInterface;

        public int SelectedExpansionIndex { get; set; }
        public int SelectedTypeIndex { get; set; }
        public int SelectedInstanceIndex { get; set; }
        public int SelectedBossIndex { get; set; } = 0;

        public int SelectedChatIndex { get; set; } = 0;

        public bool AutoSelectChat { get; set; } = true;
        public bool AutoSwapDungeon { get; set; } = true;
        public bool ShowDetails { get; set; } = true;

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