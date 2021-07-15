using System.Linq;
using Dalamud.Plugin;
using Lumina.Excel.GeneratedSheets;

namespace BossNotes
{
    public static class ZoneLookupHelper
    {
        public static void Init(DalamudPluginInterface pluginInterface)
        {
            var territorySheet = pluginInterface.Data.GetExcelSheet<TerritoryType>();
            var contentFinder = pluginInterface.Data.GetExcelSheet<ContentFinderCondition>();

            foreach (var zone in territorySheet.ToList())
            {
                var contentId = zone.Unknown10;
                var contentRow = contentFinder.GetRow(contentId);
                
            }
        }
    }
}