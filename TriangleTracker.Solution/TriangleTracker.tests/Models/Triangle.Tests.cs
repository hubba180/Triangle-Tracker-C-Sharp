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
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsTriangle());
    }
    public void IsTriangle_ExactlyTwoSidesAreEqual_True()
    {

    }
    public void IsTriangle_NoSidesAreEqual_True()
    {

    }
  }
}

// LeapYear testLeapYear = new LeapYear();
// Assert.AreEqual(true, testLeapYear.IsLeapYear(2012));