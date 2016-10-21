using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace GoudkoortsModelLib.GeneratedCode.Model
{
    public abstract class MovingObject : ITickAble
    {
        public abstract void Move();

        public abstract void Tick();
    }
}
