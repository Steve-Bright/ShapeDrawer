using System;
using SplashKitSDK;
using System.Collections.Generic;

namespace ShapeDrawer{
    public class Drawing
    {
        private readonly List<Shape> _shapes;
        private Color _background;

        
        public Drawing(Color background)
        {
            _background = background;
            _shapes = new List<Shape>();
        }

        public Drawing() : this(Color.White)
        {
            
        }

        public List<Shape> Shapes
        {
            get { return _shapes; }
        }

        public List<Shape> SelectedShapes
        {
            get {
                List<Shape> result = new List<Shape>();
                foreach (Shape s in _shapes)
                {
                    if (s.Selected == true)
                    {
                        result.Add(s);
                    }
                }
                return result; }
        }

        public int ShapeCount
        {
            get { return _shapes.Count; }
        }

        public Color Background
        {
            set { _background = value; }
            get { return _background; }
        }

        public void Draw()
        {
            SplashKit.ClearScreen(_background);
            foreach (Shape eachshape in _shapes)
            {
                eachshape.Draw();

            }
        }

        public void SelectShapesAt(Point2D pt)
        {
            foreach (Shape s in _shapes)
            {
                if (s.IsAt(pt))
                {
                    s.Selected = true;
                }
                else
                {
                    s.Selected = false;
                }
            }
        }

        public void AddShape(Shape s)
        {
            _shapes.Add(s);
        }

        public void RemoveShape(Shape s)
        {
            foreach (Shape shape in _shapes)
            {
                Console.WriteLine("shape is " + shape);
            }
            _shapes.Remove(s);
                        foreach (Shape shape in _shapes)
            {
                Console.WriteLine("shape is " + shape);
            }
        }
    }
}