using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {

        public static void Main(){
            Window window = new Window("Shapes by Swam", 800, 600);
            window.Clear(Color.White);
            Shape myShape = new Shape();
            do
            {
                myShape.Draw();
                window.Refresh();
                SplashKit.ProcessEvents();

                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    myShape.X = SplashKit.MouseX();
                    myShape.Y = SplashKit.MouseY();
                    window.Clear(Color.White);
                    window.Refresh();
                }

                if (myShape.IsAt(SplashKit.MousePosition()) == true)
                {
                    if (SplashKit.KeyTyped(KeyCode.SpaceKey) == true)
                    {
                        myShape.Color = Color.RandomRGB(33);
                        window.Refresh();
                    }
                }

            } while (!window.CloseRequested);

                SplashKit.CloseAllWindows();
            }   
        
    }
}
