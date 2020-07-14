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

    [TestMethod]
    public void IsIsosceles_TwoSidesAreEqual_True()
    {
      Triangle testTriangle = new Triangle(3, 2, 3);
      Assert.AreEqual(true, testTriangle.isIsosceles());
    }
    
    [TestMethod]
    public void IsScalene_NoSidesAreEqual_True()
    {
      Triangle testTriangle = new Triangle(3,1,2);
      Assert.AreEqual(true, testTriangle.isScalene());
    }
  }
}