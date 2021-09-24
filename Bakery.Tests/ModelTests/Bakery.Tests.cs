using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void IsBreadOrder_CreatesBreadOrder_ReturnInt5()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(5, testBread.BreadOrder(1));
    }
    [TestMethod]
    public void IsBreadOrder_CreatesBreadOrder_ReturnInt10()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(10, testBread.BreadOrder(2));
    }
    [TestMethod]
    public void IsBreadOrder_CreatesBreadOrderBOGO_ReturnInt10()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(10, testBread.BreadOrder(3));
    }
    [TestMethod]
    public void IsBreadOrder_CreatesBreadOrderBOGO_ReturnInt()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(40, testBread.BreadOrder(4));
    }


  }

  [TestClass]
  public class PastryTests
  {
   [TestMethod]
    public void PastryOrder_ReturnsPriceOf1Pastry_ReturnInt2()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(2, testPastry.PastryOrder(1));
    }

    [TestMethod]
    public void PastryOrder_ReturnsPriceOf3Pastry_ReturnInt5()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(5, testPastry.PastryOrder(3));
    }
    [TestMethod]
    public void PastryOrder_ReturnsPriceOf4Pastry_ReturnInt5()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(7, testPastry.PastryOrder(4));
    }
    [TestMethod]
    public void PastryOrder_ReturnsPriceOf5Pastry_ReturnInt9()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(9, testPastry.PastryOrder(5));
    }
    [TestMethod]
    public void PastryOrder_ReturnsPriceOf6Pastry_ReturnInt10()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(10, testPastry.PastryOrder(6));
    }
  }
}