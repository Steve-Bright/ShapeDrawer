using NUnit.Framework;
using ShapeDrawer;
using SplashKitSDK;

[TestFixture()]
public class ShapeTest
{
    [Test()]
    public void TestShapeAt()
    {
        Shape s = new Shape();

        s.X = 25;
        s.Y = 25;
        s.Width = 50;
        s.Height = 50;

        Assert.IsTrue(s.IsAt(SplashKit.PointAt(50, 50)));
        Assert.IsTrue(s.IsAt(SplashKit.PointAt(25, 25)));
        Assert.IsFalse(s.IsAt(SplashKit.PointAt(10, 50)));
        Assert.IsFalse(s.IsAt(SplashKit.PointAt(50, 10)));
    }

    [Test()]
    public void TestShapeAtWhenMovied()
    {
        Shape s = new Shape();

        s.X = 25;
        s.Y = 25;
        s.Width = 30;
        s.Height = 30;

        Assert.IsTrue(s.IsAt(SplashKit.PointAt(25, 25)));

        s.X = 100;
        s.Y = 100;
        Assert.IsFalse(s.IsAt(SplashKit.PointAt(25, 25)));
    }

    [Test()]
    public void TestShapeAtWhenResized()
    {
        Shape s = new Shape();

        s.X = 25;
        s.Y = 25;
        s.Width = 30;
        s.Height = 30;

        Assert.IsTrue(s.IsAt(SplashKit.PointAt(55, 55)));

        s.Width = 10;
        s.Height = 10;

        Assert.IsFalse(s.IsAt(SplashKit.PointAt(55, 55)));

    }

    [Test()]
    public void ShapeSelectedTest()
    {
        Shape s = new Shape();
        s.Selected = true;

        Assert.AreEqual(s.Selected, true);
    }
}