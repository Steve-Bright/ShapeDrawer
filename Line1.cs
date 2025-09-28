using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Line1 : Shape
    {
        private float _a, _b;
        private Line _line;
        public Line1(Color color, float startPointstart, float startPointend):base(color)
        {
            X = startPointstart;
            Y = startPointend;
            _a = startPointstart + 100;
            _b = startPointend + 100;
        }

        public Line1() : this(Color.Green, 0, 0)
        {
            
        }

        public override void Draw()
        {
            _line = SplashKit.LineFrom(X, Y, _a, _b);
            SplashKit.DrawLine(Color, _line);
            if (Selected)
            {
                DrawOutline();
            }
        }

        public override void DrawOutline()
        {
            SplashKit.DrawCircle(Color.Black, X - 2, Y - 2, 10);
            SplashKit.DrawCircle(Color.Black, _a - 2, _b - 2, 10);
        }

        public override bool IsAt(Point2D pt)
        {
            bool result = SplashKit.PointOnLine(pt, _line);
            Console.WriteLine("result is {0}", result);
            return result;
        }
    }
}