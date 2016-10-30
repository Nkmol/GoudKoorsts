using System;
using Model;

namespace Presentation
{
    internal class BoatView : ContainView
    {
        public BoatView(IContainObject obj) : base(obj)
        {
            CharacterToDraw = 'B';
        }

        public override void Draw()
        {
            Boat reference = GetReferenceObject<Boat>();
            if (reference.Cargo < Boat.MAX_CARGO / 2)
                Console.ForegroundColor = ConsoleColor.Green;
            else if (reference.Cargo >= Boat.MAX_CARGO)
                Console.ForegroundColor = ConsoleColor.DarkRed;
            else if(reference.Cargo >= Boat.MAX_CARGO / 2)
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                base.Draw();
        }
    }
}