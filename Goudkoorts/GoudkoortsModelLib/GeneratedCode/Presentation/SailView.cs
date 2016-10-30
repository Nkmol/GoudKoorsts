using Model;

namespace Presentation
{
    internal class SailView : TileView
    {
        public SailView(Tile tile) : base(tile)
        {
            CharacterToDraw = '-';
        }
    }
}