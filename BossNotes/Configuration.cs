using System;
using Dalamud.Configuration;
using Dalamud.Plugin;

namespace BossNotes
{
    public class Configuration : IPluginConfiguration
    {
        [NonSerialized]
        private DalamudPluginInterface _pluginInterface;
        
        public int Version { get; set; } = 0;
        public int SelectedExpansion { get; set; } = 0;

        public void Initialize(DalamudPluginInterface pluginInterface)
        {
            _pluginInterface = pluginInterface;
        }
        
        public void Save()
        {
            _pluginInterface.SavePluginConfig(this);
        }
    }
}