using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Rectangle1 : Shape
    {
        private int _width, _height;
        public int Width
        {
            set { _width = value; }
            get { return _width; }
        }

        public int Height
        {
            set { _height = value; }
            get { return _height; }
        }

        public Rectangle1() : this(Color.Green, 0, 0, 100, 100)
        {

        }

        public Rectangle1(Color color, float x, float y, int width, int height) : base(color)
        {
            X = x;
            Y = y;
            _width = width;
            _height = height;
        }

        public override void Draw()
        {
            SplashKit.FillRectangle(Color, X, Y, _width, _height);
            if (Selected)
            {
                DrawOutline();
            }
        }

        public override void DrawOutline()
        {
            SplashKit.DrawRectangle(Color.Black, X - 2, Y - 2, _width + 4, _height + 4);
        }

        public override bool IsAt(Point2D pt)
        {
            bool result = SplashKit.PointInRectangle(pt.X, pt.Y, X, Y, _width, _height);
            return result;
        }
    }   
}