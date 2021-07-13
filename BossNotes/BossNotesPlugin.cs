using Dalamud.Configuration;
using Dalamud.Plugin;
using Dalamud.Game.Command;

namespace BossNotes
{
    public class BossNotesPlugin : IDalamudPlugin
    {
        private const string Command = "/bnotes";
        
        private DalamudPluginInterface _pluginInterface;
        private Configuration _configuration;
        private UI _ui;
        
        public string AssemblyLocation { get => assemblyLocation; set => assemblyLocation = value; }
        private string assemblyLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;

        public void Dispose()
        {
            _ui.Dispose();
            _pluginInterface.CommandManager.RemoveHandler(Command);
            _pluginInterface.Dispose();
        }

        public void Initialize(DalamudPluginInterface pluginInterface)
        {
            _pluginInterface = pluginInterface;
            _configuration = pluginInterface.GetPluginConfig() as Configuration ?? new Configuration();
            _configuration.Initialize(_pluginInterface);

            _ui = new UI(_configuration);

            _pluginInterface.CommandManager.AddHandler(Command, new CommandInfo(OnCommand)
            {
                HelpMessage = "Displays quick notes for bosses and lets you print strats to chat."
            });

            _pluginInterface.UiBuilder.OnBuildUi += DrawUI;
        }

        private void OnCommand(string command, string args)
        {
            _ui.Visible = !_ui.Visible;
        }

        private void DrawUI()
        {
            _ui.Draw();
        }

        public string Name => "Boss Notes";
    }
}