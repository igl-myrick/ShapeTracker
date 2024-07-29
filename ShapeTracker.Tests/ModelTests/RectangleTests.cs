using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class RectangleTests
  {

    [TestMethod]
    public void RectangleConstructor_CreatesInstanceOfRectangle_Rectangle()
    {
      Rectangle newRectangle = new Rectangle(5,4);
      Assert.AreEqual(typeof(Rectangle), newRectangle.GetType());
    }

    [TestMethod]
    public void GetSide1_ReturnsSide1_Int()
    {
      int length1 = 5;
      int length2 = 4;
      Rectangle newRectangle = new Rectangle(length1, length2);
      int result = newRectangle.Side1;
      Assert.AreEqual(length1, result);
    }

    [TestMethod]
    public void GetSide2_ReturnsSide2_Int()
    {
      int length1 = 5;
      int length2 = 4;
      Rectangle newRectangle = new Rectangle(length1, length2);
      int result = newRectangle.Side2;
      Assert.AreEqual(length2, result);
    }

    [TestMethod]
    public void SetSide2_SetsValueOfSide1_Void()
    {
      Rectangle newRectangle = new Rectangle(5,4);
      int newLength1 = 7;
      newRectangle.Side1 = newLength1;
      Assert.AreEqual(newLength1, newRectangle.Side1);
    }
  }
}