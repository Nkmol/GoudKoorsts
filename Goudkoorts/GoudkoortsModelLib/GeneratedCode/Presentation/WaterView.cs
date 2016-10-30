using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Presentation
{
    class WaterView : TileView
    {
        public WaterView(Tile tile) : base(tile)
        {
            CharacterToDraw = '~';
        }
    }
}
