using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Line1 : Shape
    {
        private float _a, _b;
        private Line _line;
        public Line1(float endPointStart, float endPointEnd)
        {
            _a = endPointStart;
            _b = endPointEnd;
        }

        public Line1()
        {

        }

        public override void Draw()
        {
            _line = SplashKit.LineFrom(X, Y, _a, _b);
        }

        public override void DrawOutline()
        {
            // SplashKit.DrawCircle(Color.Black, X - 2, Y - 2, _radius + 4);
        }

        public override bool IsAt(Point2D pt)
        {
            return SplashKit.PointOnLine(pt, _line);
        }
    }
}