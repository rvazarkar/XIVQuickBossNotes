using System.Reflection;
using Dalamud.Game.Command;
using Dalamud.Plugin;

namespace BossNotes
{
    public class BossNotesPlugin : IDalamudPlugin
    {
        private const string Command = "/bnotes";
        private Configuration _configuration;

        private DalamudPluginInterface _pluginInterface;
        private UI _ui;

        public string AssemblyLocation { get; set; } = Assembly.GetExecutingAssembly().Location;

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

        public string Name => "Boss Notes";

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