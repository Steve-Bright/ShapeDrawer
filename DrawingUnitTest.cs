using System;
using SplashKitSDK;
using NUnit.Framework;

namespace ShapeDrawer
{
    [TestFixture()]
    public class ShapeDrawerTest
    {
        [Test()]
        public void TestDefaultInitialization()
        {
            Drawing drawingOne = new Drawing();

            Assert.AreEqual(drawingOne.Background, Color.White);
        }

        [Test()]
        public void TestInitializeWithColor()
        {
            Drawing drawingOne = new Drawing(Color.Blue);

            Assert.AreEqual(drawingOne.Background, Color.Blue);
        }

        [Test()]
        public void TestAddShape()
        {
            Drawing myDrawing = new Drawing();
            int count = myDrawing.ShapeCount;

            Assert.AreEqual(0, count);

            myDrawing.AddShape(new Rectangle1());
            myDrawing.AddShape(new Rectangle1());
            count = myDrawing.ShapeCount;
            Assert.AreEqual(2, count);
        }

        [Test()]
        public void TestSelectShape()
        {
            Drawing myDrawing = new Drawing();
            Shape[] testShapes = {
                new Rectangle1(Color.Red, 25, 25, 50, 50),
                new Rectangle1(Color.Green, 25, 10, 50, 50),
                new Rectangle1(Color.Blue, 10, 25, 50, 50) };
            foreach (Shape s in testShapes) myDrawing.AddShape(s);

            List<Shape> selected;

            Point2D point;
            point = SplashKit.PointAt(70, 70);

            myDrawing.SelectShapesAt(point);
            selected = myDrawing.SelectedShapes;

            CollectionAssert.Contains(selected, testShapes[0]);
            Assert.AreEqual(1, selected.Count);
            point = SplashKit.PointAt(70, 50);
            myDrawing.SelectShapesAt(point);
            selected = myDrawing.SelectedShapes;
            CollectionAssert.Contains(selected, testShapes[0]);
            CollectionAssert.Contains(selected, testShapes[1]);
            Assert.AreEqual(2, selected.Count);

        }

        [Test()]
        public void RemoveShapeTest()
        {
            Drawing myDrawing = new Drawing();
            Shape[] testShapes = {
                new Rectangle1(Color.Red, 25, 25, 50, 50),
                new Rectangle1(Color.Green, 25, 10, 50, 50),
                new Rectangle1(Color.Blue, 10, 25, 50, 50) };
            foreach (Shape s in testShapes) myDrawing.AddShape(s);


            Assert.AreEqual(3, myDrawing.ShapeCount);
            myDrawing.RemoveShape(testShapes[0]);
            Assert.AreEqual(2, myDrawing.ShapeCount);
            
            List<Shape> selected;

            Point2D point;
            point = SplashKit.PointAt(70, 70);

            myDrawing.SelectShapesAt(point);
            selected = myDrawing.SelectedShapes;

            CollectionAssert.DoesNotContain(selected, testShapes[0]);
      
        }
    }
}