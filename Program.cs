using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {

        public static void Main(){
            Window window = new Window("Shapes by Swam", 800, 600);
            window.Clear(Color.White);
            Drawing drawingOne = new Drawing();
            // Shape myShape = new Shape();
            do
            {


                // window.Refresh();
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(Color.White);

                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape myShape = new Shape();
                    myShape.X = SplashKit.MouseX();
                    myShape.Y = SplashKit.MouseY();
                    myShape.Draw();
                    drawingOne.AddShape(myShape);
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
