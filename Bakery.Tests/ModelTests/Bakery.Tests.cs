using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void IsBreadOrder_CreatesBreadOrder_ReturnPrice()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(10, testBread.BreadOrder(3));
    }
  }

  [TestClass]
  public class PastryTests
  {
   [TestMethod]
    public void PastryOrder_ReturnsPriceOf1Pastry_ReturnPrice2()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(2, testPastry.PastryOrder(1));
    }

    [TestMethod]
    public void PastryOrder_ReturnsPriceOf3Pastry_ReturnPrice5()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(5, testPastry.PastryOrder(3));
    }
    [TestMethod]
    public void PastryOrder_ReturnsPriceOf4Pastry_ReturnPrice()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(10, testPastry.PastryOrder(6));
    }
    [TestMethod]
    public void PastryOrder_ReturnsPriceOf4Pastry_ReturnPrice12()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(12, testPastry.PastryOrder(7));
    }
    [TestMethod]
    public void PastryOrder_ReturnsPriceOf4Pastry_ReturnPrice14()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(14, testPastry.PastryOrder(8));
    }
  }
}