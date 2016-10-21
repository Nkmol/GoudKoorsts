using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class DynamicDoubleList<T> : List<List<T>> 
    {
        public T this[int x, int y]
        {
            get
            {
                return base[y][x];
            }
            set
            {
                if(y >= Count || base[y] == null)
                    Add(new List<T>());

                base[y].Add(value);
            }
        }
    }
}
