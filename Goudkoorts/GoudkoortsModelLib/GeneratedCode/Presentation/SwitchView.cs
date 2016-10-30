using Model;

namespace Presentation
{
    internal class SwitchView : TileView
    {
        public SwitchView(Tile tile) : base(tile)
        {
            CharacterToDraw = 'S';
        }

        public override void Draw()
        {
            SwitchTile reference = (SwitchTile) ReferenceTile;

            if(reference.Direction == null)
                CharacterToDraw = reference.OpenSide.Equals(Point.Up) ? '┛' : '┓';
            else if(reference.Direction.Equals(Point.Right))
                CharacterToDraw = reference.OpenSide.Equals(Point.Up) ? '┗' : '┏';

            base.Draw();
        }
    }
}