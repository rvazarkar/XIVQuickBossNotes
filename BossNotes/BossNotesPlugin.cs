using Dalamud.Configuration;
using Dalamud.Plugin;
using Dalamud.Game.Command;

namespace BossNotes
{
    public class BossNotesPlugin : IDalamudPlugin
    {
        private DalamudPluginInterface _pluginInterface;
        private Configuration _configuration;

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public void Initialize(DalamudPluginInterface pluginInterface)
        {
            _pluginInterface = pluginInterface;
            _configuration = pluginInterface.GetPluginConfig() as Configuration ?? new Configuration();
        }

        public string Name => "Boss Notes";
    }
}