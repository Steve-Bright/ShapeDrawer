using System;
using SplashKitSDK;

namespace ShapeDrawer{
    public class Shape
    {
        private Color _color;
        private float _x, _y;
        private int _width, _height;
        private bool _selected;


        public Shape(Color color, float x, float y, int width, int height)
        {
            _color = color;
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }

        public Shape() : this(Color.Green, 0, 0, 100, 100)
        {

        }

        public Color Color
        {
            set { _color = value; }
            get { return _color; }
        }

        public float X
        {
            set { _x = value; }
            get { return _x; }
        }

        public float Y
        {
            set { _y = value; }
            get { return _y; }
        }

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

        public bool Selected
        {
            set { _selected = value; }
            get { return _selected; }
        }

        public void Draw()
        {
            SplashKit.FillRectangle(_color, _x, _y, _width, _height);
            if (_selected == true)
            {
                this.DrawOutline();
            }
        }

        public void DrawOutline()
        {
             SplashKit.DrawRectangle(Color.Black, _x - 2, _y - 2, _width+ 4, _height + 4);
        }

        public bool IsAt(Point2D pt)
        {
            bool result = SplashKit.PointInRectangle(pt.X, pt.Y, _x, _y, _width, _height);
            return result;
        }
    }
}