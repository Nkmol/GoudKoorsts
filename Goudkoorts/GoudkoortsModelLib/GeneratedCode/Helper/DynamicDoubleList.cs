using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Helper
{
    public class DynamicDoubleList<T> : List<List<T>> 
    {
        // Only meant for setting the Double List in a more dynamic way.
        public T this[int x, int y]
        {
            set
            {
                if(y >= Count || base[y] == null)
                    Add(new List<T>());

                base[y].Add(value);
            }
        }
    }
}
