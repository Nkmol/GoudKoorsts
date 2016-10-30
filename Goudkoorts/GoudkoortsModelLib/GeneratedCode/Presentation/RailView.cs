using Model;

namespace Presentation
{
    internal class RailView : TileView
    {
        public RailView(Tile tile) : base(tile)
        {
            CharacterToDraw = '.';
        }
    }
}