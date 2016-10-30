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

        public static Point operator -(Point c1, Point c2)
        {
            return new Point(c1.x - c2.x, c1.y - c2.y);
        }

        public override bool Equals(object c2)
        {
            Point p2 = (Point)c2;
            return x == p2.x && y == p2.y;
        }

        protected bool Equals(Point other)
        {
            return x == other.x && y == other.y;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (x * 397) ^ y;
            }
        }

        public static Point Left => new Point(-1, 0);
        public static Point Right => new Point(1, 0);
        public static Point Up => new Point(0, -1);
        public static Point Down => new Point(0, 1);
    }

    static class PointExtension
    {
        
    }
}
