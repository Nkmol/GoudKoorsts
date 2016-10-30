using Model;

namespace Presentation
{
    internal class PortView : TileView
    {
        public PortView(Tile tile) : base(tile)
        {
            CharacterToDraw = 'P';
        }
    }
}