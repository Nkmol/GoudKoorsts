using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    class TileView : IDrawAble
    {
        protected ContainView _contain;
        protected char CharacterToDraw;

        public TileView(Tile tile)
        {
            CharacterToDraw = ' ';
            _contain = FactoryView.CreateContain(tile.Contain);
        }

        public virtual void Draw()
        {
            if (_contain != null)
                _contain.Draw(); // if not null
            else
               Console.Write(CharacterToDraw);
        }
    }
}
