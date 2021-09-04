using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Microsoft.Build.Utilities;

namespace NotesValidator
{
    public class Validator : Task
    {
        private const int MaxPrefixLength = 9;
        private bool _clean = true;

        private readonly Dictionary<ushort, string> _zoneIds = new();
        public string ProjectDir { get; set; }

        private void DirSearch(string directory)
        {
            foreach (var d in Directory.GetDirectories(directory)) DirSearch(d);

            foreach (var f in Directory.GetFiles(directory, "*.json"))
            {
                var json = File.ReadAllText(f);
                ValidatorInstance dungeon;
                try
                {
                    dungeon = JsonSerializer.Deserialize<ValidatorInstance>(json);
                }
                catch
                {
                    continue;
                }

                var zid = dungeon.ZoneID;
                Log.LogMessage($"Zone ID: {zid}");

                if (_zoneIds.ContainsKey(zid))
                {
                    Log.LogError($"Duplicate zone id in {dungeon.Name} and {_zoneIds[zid]}");
                    _clean = false;
                }
                else
                {
                    _zoneIds.Add(zid, dungeon.Name);
                }

                foreach (var boss in dungeon.Bosses)
                {
                    var baseMessage =
                        $"★{boss.Name}★: {boss.QuickStrategy}";
                    var lines = baseMessage.Replace("\r", string.Empty).Split('\n');
                    foreach (var line in lines)
                        if (line.Length + MaxPrefixLength >= 179)
                        {
                            Log.LogError($"Quick strategy for {boss.Name} in {f} is too long: {line}");
                            _clean = false;
                        }
                }
            }
        }

        public override bool Execute()
        {
            Log.LogMessage($"Validating quick strategy length for directory {ProjectDir}");
            DirSearch(ProjectDir);
            return _clean;
        }
    }
}