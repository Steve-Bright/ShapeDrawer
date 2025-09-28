using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {
        private enum ShapeKind
        {
            Rectangle,
            Circle
        }

        public static void Main()
        {
            ShapeKind kindToAdd = ShapeKind.Circle;
            Window window = new Window("Shapes by Swam", 800, 600);
            window.Clear(Color.White);
            Drawing drawingOne = new Drawing();
            // Shape myShape = new Shape();
            do
            {


                // window.Refresh();
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(Color.White);

                if (SplashKit.KeyTyped(KeyCode.RKey) == true)
                {
                    kindToAdd = ShapeKind.Rectangle;
                }

                if (SplashKit.KeyTyped(KeyCode.CKey) == true)
                {
                    kindToAdd = ShapeKind.Circle;
                }

                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape newShape;
                    if (kindToAdd == ShapeKind.Circle)
                    {
                        Circle1 newCircle = new Circle1();
                        newCircle.X = SplashKit.MouseX();
                        newCircle.Y = SplashKit.MouseY();
                        newShape = newCircle;
                    }
                    else
                    {
                        Rectangle1 newRect = new Rectangle1();
                        newRect.X = SplashKit.MouseX();
                        newRect.Y = SplashKit.MouseY();
                        newShape = newRect;
                    }
                    drawingOne.AddShape(newShape);
                    // Console.WriteLine("The drawings are "+ drawingOne.ShapeCount);
                    // window.Clear(Color.White);
                    // window.Refresh();
                }

                // if (myShape.IsAt(SplashKit.MousePosition()) == true)
                // {
                //     if (SplashKit.KeyTyped(KeyCode.SpaceKey) == true)
                //     {
                //         myShape.Color = Color.RandomRGB(33);
                //         window.Refresh();
                //     }
                // }

                if (SplashKit.KeyTyped(KeyCode.SpaceKey) == true)
                {
                    // drawingOne.Draw(window);
                    drawingOne.Background = SplashKit.RandomRGBColor(33);
                    // window.Refresh();
                }

                if (SplashKit.MouseClicked(MouseButton.RightButton) == true)
                {
                    Point2D point = SplashKit.PointAt(SplashKit.MouseX(), SplashKit.MouseY());
                    drawingOne.SelectShapesAt(point);

                }

                if (SplashKit.KeyTyped(KeyCode.BackspaceKey) == true)
                {
                    List<Shape> selected = drawingOne.SelectedShapes;
                    foreach (Shape selectedShape in selected)
                    {
                        drawingOne.RemoveShape(selectedShape);
                    }

                }

                drawingOne.Draw();
                SplashKit.RefreshScreen(60);

            } while (!window.CloseRequested);

            SplashKit.CloseAllWindows();
        }   
        
    }
}
