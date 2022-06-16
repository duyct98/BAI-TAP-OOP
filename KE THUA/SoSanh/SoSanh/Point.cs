using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoSanh
{
    internal class Point : IComparable<Point>
    {   
        public int X;
        public int Y;
        public static List<Point> list = new List<Point>();
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point()
        {
        }

        public static void addPoint(int x,int y)
        {
            list.Add(new Point(x,y));            
        } 
        public static void info()
        {
            

            Console.WriteLine();
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write("\n {0} {1} ", list[i].X, list[i].Y);
            }

        }



        public string toString()
        {
            return X.ToString();
        }

        public int CompareTo(Point other)
        {
            if(X > other.X)
            {
                return -1;
            }
            else if (X < other.X)
            {
                return 1;
            }
            else return 0;

        }

       
    }
}
