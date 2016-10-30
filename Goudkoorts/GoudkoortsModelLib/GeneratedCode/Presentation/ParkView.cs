using System;
using Model;

namespace Presentation
{
    internal class ParkView : TileView
    {
        public ParkView(Tile tile) : base(tile)
        {
            CharacterToDraw = 'P';
        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            base.Draw();
        }
    }
}