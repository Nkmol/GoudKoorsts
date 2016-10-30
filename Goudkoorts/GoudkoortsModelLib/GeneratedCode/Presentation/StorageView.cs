using Model;

namespace Presentation
{
    internal class StorageView : ContainView
    {
        public StorageView(IContainObject obj) : base(obj)
        {
            CharacterToDraw = 'L';
        }
    }
}