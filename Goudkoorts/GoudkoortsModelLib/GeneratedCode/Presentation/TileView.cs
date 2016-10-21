using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoudkoortsModelLib.GeneratedCode.Presentation
{
    class TileView
    {
        private static readonly Dictionary<String, char> tileViewMapping = new Dictionary<String, char>()
        {
            {"Boat", 'B' },
            {"Cart", 'C' },
            {"PortTile", 'P' },
            {"RailTile", '.' },
            {"ParkTile", 'G' },
            {"SailTile", '-' },
            {"SwitchTile", 'S' },
            {"WaterTile", '~' },
            {"Tile", ' ' },
            {"Storage", 'L' },
        };

        public static char Create(Tile tile)
        {
            string search;
            if (tile.Contain != null)
                search = tile.Contain.GetType().Name;
            else
                search = tile.GetType().Name;

            return TileView.tileViewMapping[search];
        }
    }
}
