using Model;

namespace Presentation
{
    internal class BoatView : ContainView
    {
        public BoatView(IContainObject obj) : base(obj)
        {
            CharacterToDraw = 'B';
        }
    }
}