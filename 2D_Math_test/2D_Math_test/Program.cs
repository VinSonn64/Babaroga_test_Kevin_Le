using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Math_test
{
    class Program
    {
       

        static void Main(string[] args)
        {
            
        }
    }

    struct Rectangle
    { /* Each point represents one of the Rectangle's corners. */
         public Point p1, p2, p3, p4;

        public double DegreeToRadian(double angle) //Convert Degrees to Radians for Trig functions
        {
            return Math.PI * angle / 180.0;
        }


       public void Rotate(Point origin, float angle)
        {       
            //Move point of rotation to origin, rotate, then return back to original location.

            p1.x = (float)(Math.Cos(DegreeToRadian(angle)) * (p1.x -origin.x) - Math.Sin(DegreeToRadian(angle)) * (p1.y - origin.y) + origin.x);
            p1.y = (float)(Math.Sin(DegreeToRadian(angle)) * (p1.x - origin.x) + Math.Cos(DegreeToRadian(angle)) * (p1.y - origin.y) + origin.y);

            p2.x = (float)(Math.Cos(DegreeToRadian(angle)) * (p2.x - origin.x) - Math.Sin(DegreeToRadian(angle)) * (p2.y - origin.y) + origin.x);
            p2.y = (float)(Math.Sin(DegreeToRadian(angle)) * (p2.x - origin.x) + Math.Cos(DegreeToRadian(angle)) * (p2.y - origin.y) + origin.y);

            p3.x = (float)(Math.Cos(DegreeToRadian(angle)) * (p3.x - origin.x) - Math.Sin(DegreeToRadian(angle)) * (p3.y - origin.y) + origin.x);
            p3.y = (float)(Math.Sin(DegreeToRadian(angle)) * (p3.x - origin.x) + Math.Cos(DegreeToRadian(angle)) * (p3.y - origin.y) + origin.y);

            p4.x = (float)(Math.Cos(DegreeToRadian(angle)) * (p4.x - origin.x) - Math.Sin(DegreeToRadian(angle)) * (p4.y - origin.y) + origin.x);
            p4.y = (float)(Math.Sin(DegreeToRadian(angle)) * (p4.x - origin.x) + Math.Cos(DegreeToRadian(angle)) * (p4.y - origin.y) + origin.y);
        }

     
    }

    struct Point { public float x, y; }

    
}
