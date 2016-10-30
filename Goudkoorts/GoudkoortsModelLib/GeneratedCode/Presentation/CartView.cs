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
            Cart reference = GetReferenceObject<Cart>();
            if (reference.Tile is ParkTile)
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            else if (reference.isEmpty)
                Console.ForegroundColor = ConsoleColor.Green;
            else if(reference.Tile is PortTile)
                Console.ForegroundColor = ConsoleColor.Blue;
            else
                Console.ForegroundColor = ConsoleColor.Red;

            base.Draw();
        }
    }
}
