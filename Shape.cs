using System;
using SplashKitSDK;

namespace ShapeDrawer{
    public class Shape{
        private Color _color;
        private float _x, _y;
        private int _width, _height;

        public Shape(){
            _color = Color.Green;
            _x = 0;
            _y = 0;
            _width = 100;
            _height = 100;
        }

        public Color Color{
            set{_color = value;}
            get{return _color;}
        }

        public float X{
            set{_x = value;}
            get{return _x;}
        }

        public float Y{
            set{_y = value;}
            get{return _y;}
        }

        public int Width{
            set{_width = value;}
            get{return _width;}
        }

        public int Height{
            set{_height = value;}
            get{return _height;}
        }

        public void Draw(){
            SplashKit.FillRectangle(_color, _x, _y, _width, _height);
        }

        public bool IsAt(Point2D pt)
        {
            bool result = SplashKit.PointInRectangle(pt.X, pt.Y, _x, _y, _width, _height);
            return result;
        }
    }
}