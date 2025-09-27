using System;
using SplashKitSDK;

namespace ShapeDrawer{
    public class Shape
    {
        private Color _color;
        private float _x, _y;
        private bool _selected;


        public Shape(Color color)
        {
            _color = color;
        }

        public Shape() : this(Color.White)
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



        public bool Selected
        {
            set { _selected = value; }
            get { return _selected; }
        }

        public virtual void Draw()
        {
        }

        public virtual void DrawOutline()
        {
        }

        public virtual bool IsAt(Point2D pt)
        {
            return false;
        }
    }
}