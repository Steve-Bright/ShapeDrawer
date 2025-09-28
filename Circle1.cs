using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Circle1 : Shape
    {
        private int _radius;

        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public Circle1():this(Color.Green, 50)
        {
        }

        public Circle1(Color color, int radius)
        {
            _radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine("Color is {0}", Color);
            Console.WriteLine("X is {0}", X);
            Console.WriteLine("Y is {0}", Y);
            Console.WriteLine("_radius is {0}", _radius);
            SplashKit.FillCircle(base.Color, X, Y, _radius);
            if (Selected)
            {
                DrawOutline();
            }
        }

        public override void DrawOutline()
        {
            SplashKit.DrawCircle(Color.Black, X - 2, Y - 2, _radius + 4);
        }

        public override bool IsAt(Point2D pt)
        {
            bool result = SplashKit.PointInCircle(pt.X, pt.Y, X, Y, _radius);
            return result;
        }
        
    }
}