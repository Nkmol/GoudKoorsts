using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }
        
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Point operator +(Point c1, Point c2)
        {
            return new Point(c1.x + c2.x, c1.y + c2.y);
        }

        public static Point operator *(Point c1, Point c2)
        {
            return new Point(c1.x * c2.x, c1.y * c2.y);
        }

    }
}
