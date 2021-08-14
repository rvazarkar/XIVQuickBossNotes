using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using Dalamud;
using Dalamud.Plugin;
using Newtonsoft.Json;

namespace BossNotes
{
    public class Expansion
    {
        public Expansion(string expansionFolder, ClientLanguage language)
        {
            // var folder = language switch
            // {
            //     ClientLanguage.Japanese => "JPN",
            //     ClientLanguage.English => "ENG",
            //     ClientLanguage.German => "GER",
            //     ClientLanguage.French => "FR",
            //     _ => throw new ArgumentOutOfRangeException(nameof(language), language, null)
            // };
            //
            // var pluginPath = BossNotesPlugin.AssemblyLocationInternal;
            // PluginLog.LogInformation($"Loading expansion content from {pluginPath}");
            // if (pluginPath == null)
            // {
            //     PluginLog.LogError("Pluginpath is null, unable to load expansion");
            //     return;
            // }

            // var basePath = Path.Combine(pluginPath, folder, expansionFolder);
            // PluginLog.LogInformation($"BasePath is {basePath}");
            // if (!Directory.Exists(basePath))
            // {
            //     PluginLog.LogError("Directory for JSON files does not exist.");
            //     return;
            // }
            
            PluginLog.LogInformation($"Loading expansion content from {expansionFolder}");

            // Dungeons = LoadFolder(Path.Combine(expansionFolder, "Dungeons"));
            Trials = LoadFolder(Path.Combine(expansionFolder, "Trials"));
            // HighEndTrials = LoadFolder(Path.Combine(expansionFolder, "HighEndTrials"));
            // Raids = LoadFolder(Path.Combine(expansionFolder, "Raids"));
            // AllianceRaids = LoadFolder(Path.Combine(expansionFolder, "AllianceRaids"));
        }
        
        private static Instance[] LoadFolder(string folder)
        {
            PluginLog.LogInformation($"Loading folder {folder}");
            if (!Directory.Exists(folder))
            {
                return new Instance[]
                {
                    new PlaceholderInstance()
                };
            }
            
            PluginLog.LogInformation($"Directory exists");
            
            var instances = Directory.GetFiles(folder, "*.json").Select(x =>
            {
                var json = File.ReadAllText(x);
                return JsonConvert.DeserializeObject<Instance>(json);
            }).OrderBy(x => x.Index).ToArray();

            if (instances.Length == 0)
            {
                return new Instance[]
                {
                    new PlaceholderInstance()
                };
            }

            return instances;
        }
        
        public string Name { get; protected set; }

        public Instance[] Dungeons { get; protected set; } =
        {
            new PlaceholderInstance()
        };

        public Instance[] Trials { get; protected set; } =
        {
            new PlaceholderInstance()
        };

        public Instance[] HighEndTrials { get; protected set; } =
        {
            new PlaceholderInstance()
        };

        public Instance[] Raids { get; protected set; } =
        {
            new PlaceholderInstance()
        };

        public Instance[] AllianceRaids { get; protected set; } =
        {
            new PlaceholderInstance()
        };
    }
}