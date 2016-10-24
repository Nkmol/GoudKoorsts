using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Helper
{
    public class DynamicDoubleList<T> : List<List<T>>
    {

        private Dictionary<Type, Dictionary<Point, T>> _typeArray = new Dictionary<Type, Dictionary<Point, T>>();

        // Only meant for setting the Double List in a more dynamic way.
        public T this[int x, int y]
        {
            set
            {
                if(y >= Count || base[y] == null)
                    Add(new List<T>());

                if (!_typeArray.ContainsKey(value.GetType())){
                    _typeArray.Add(value.GetType(), new Dictionary<Point, T>() { { new Point(x, y), value } });
                } else {

                    _typeArray[value.GetType()].Add(new Point(x, y), value);
                }

                base[y].Add(value);
            }
        }


        public List<T> Get<TClass>() where TClass : T
        {
            return new List<T>(_typeArray[typeof(TClass)].Values);
        }

        public T Get(Point p)
        {
            return base[p.y][p.x];
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
