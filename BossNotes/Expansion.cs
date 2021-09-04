using System.IO;
using System.Linq;
using System.Text.Json;

namespace BossNotes
{
    public class Expansion
    {
        public Expansion(string expansionFolder)
        {
            Dungeons = LoadFolder(Path.Combine(expansionFolder, "Dungeons"));
            Trials = LoadFolder(Path.Combine(expansionFolder, "Trials"));
            HighEndTrials = LoadFolder(Path.Combine(expansionFolder, "HighEndTrials"));
            Raids = LoadFolder(Path.Combine(expansionFolder, "Raids"));
            SavageRaids = LoadFolder(Path.Combine(expansionFolder, "SavageRaids"));
            AllianceRaids = LoadFolder(Path.Combine(expansionFolder, "AllianceRaids"));
        }

        public string Name { get; protected set; }

        public Instance[] Dungeons { get; protected set; }

        public Instance[] Trials { get; protected set; }

        public Instance[] HighEndTrials { get; protected set; }

        public Instance[] Raids { get; protected set; }
        public Instance[] SavageRaids { get; protected set; }

        public Instance[] AllianceRaids { get; protected set; }

        private static Instance[] LoadFolder(string folder)
        {
            if (!Directory.Exists(folder))
                return new Instance[]
                {
                    new PlaceholderInstance()
                };

            var instances = Directory.GetFiles(folder, "*.json").Select(x =>
            {
                var json = File.ReadAllText(x);
                return JsonSerializer.Deserialize<Instance>(json);
            }).OrderBy(x => x.Index).ToArray();

            if (instances.Length == 0)
                return new Instance[]
                {
                    new PlaceholderInstance()
                };

            return instances;
        }
    }
}