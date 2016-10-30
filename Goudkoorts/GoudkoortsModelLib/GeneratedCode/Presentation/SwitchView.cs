using Model;

namespace Presentation
{
    internal class SwitchView : TileView
    {
        public SwitchView(Tile tile) : base(tile)
        {
            CharacterToDraw = 'S';
        }
    }
}