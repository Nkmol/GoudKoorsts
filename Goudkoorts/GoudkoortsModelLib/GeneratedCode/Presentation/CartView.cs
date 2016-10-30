using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Presentation
{
    class CartView : ContainView
    {
        public CartView(IContainObject cart) : base(cart)
        {
            CharacterToDraw = 'C';
        }

        public override void Draw()
        {
            if(GetReferenceObject<Cart>().Tile is ParkTile)
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            else if (GetReferenceObject<Cart>().isEmpty)
                Console.ForegroundColor = ConsoleColor.Green;
            else
                Console.ForegroundColor = ConsoleColor.Red;

            base.Draw();
        }
    }
}
