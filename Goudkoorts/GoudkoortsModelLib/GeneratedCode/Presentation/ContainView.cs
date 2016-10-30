using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Presentation
{
    abstract class ContainView : IDrawAble
    {
        protected char CharacterToDraw;
        private readonly IContainObject _referenceObject;

        public ContainView(IContainObject obj)
        {
            _referenceObject = obj;
        }

        public virtual void Draw()
        {
            Console.Write(CharacterToDraw);
        }
        protected T GetReferenceObject<T>() where T : IContainObject
        {
            return (T)_referenceObject;
        }
    }
}
