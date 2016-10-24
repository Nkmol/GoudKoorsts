using Model;
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

        Dictionary<Type, List<T>> typesAdded = new Dictionary<Type, List<T>>();

        Dictionary<Point, T> specifics = new Dictionary<Point, T>();
       
        // Only meant for setting the Double List in a more dynamic way.
        public T this[int x, int y]
        {
            set
            {
                if(y >= Count || base[y] == null)
                    Add(new List<T>());

                

                if (!typesAdded.ContainsKey(value.GetType())){
                    typesAdded.Add(value.GetType(), new List<T> { value });
                } else {

                    typesAdded[value.GetType()].Add(value);
                }

                specifics.Add(new Point(x, y), value);

                base[y].Add(value);
            }
        }



        public List<T> Get<TClass>() where TClass : T
        {
            var type = typeof(TClass);

            return typesAdded[type];
        }

        public TClass Get<TClass>(Point p) where TClass : T
        {
            T value = base[p.y][p.x];
            if (value is TClass)
                return (TClass)value;
            else
                return default(TClass);
        }

    }
}
