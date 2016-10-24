using Model;
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
        Dictionary<Type, List<T>> typesAdded = new Dictionary<Type, List<T>>();

        Dictionary<Point, T> specifics = new Dictionary<Point, T>();
        
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

                if (!typesAdded.ContainsKey(typeof(T))){
                    typesAdded.Add(typeof(T), new List<T> { value });
                } else {
                    typesAdded[typeof(T)].Add(value);
                }

                specifics.Add(new Point(x, y), value);

                base[y].Add(value);
            }
        }



        public List<T> GetAll<TClass>() where TClass : T
        {
            return typesAdded[typeof(TClass)];
        }

    }
}
