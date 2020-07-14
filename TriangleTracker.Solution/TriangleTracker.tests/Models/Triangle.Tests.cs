using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;


namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsTriangle_AllSidesAreEqual_True()
    {
      Triangle testTriangle = new Triangle(3, 3, 3);
      Assert.AreEqual(true, testTriangle.isEquilateral());
    }
    public void IsIsosceles_TwoSidesAreEqual_True()
    {
      Triangle testTriangle = new Triangle(3, 2, 3);
      Assert.AreEqual(true, testTriangle.isEquilateral());
    }
    // public void IsScalene_NoSidesAreEqual_True()
    // {
    //   Triangle testTriangle = new Triangle();
    // }
  }
}

// LeapYear testLeapYear = new LeapYear();
// Assert.AreEqual(true, testLeapYear.IsLeapYear(2012));