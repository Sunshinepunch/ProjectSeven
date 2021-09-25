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
    public void PastryOrder_ReturnsPriceOf6Pastry_ReturnPrice()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(10, testPastry.PastryOrder(6));
    }
    [TestMethod]
    public void PastryOrder_ReturnsPriceOf7Pastry_ReturnPrice()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(12, testPastry.PastryOrder(7));
    }
    [TestMethod]
    public void PastryOrder_ReturnsPriceOf8Pastry_ReturnPrice()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(14, testPastry.PastryOrder(8));
    }
    [TestMethod]
    public void PastryOrder_ReturnsPriceOf9Pastry_ReturnPrice()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(15, testPastry.PastryOrder(9));
    }
    [TestMethod]
    public void PastryOrder_ReturnsPriceOf10Pastry_ReturnPrice()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(17, testPastry.PastryOrder(10));
    }
    [TestMethod]
    public void PastryOrder_ReturnsPriceOf11Pastry_ReturnPrice()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(19, testPastry.PastryOrder(11));
    }
  }
  [TestClass]
  public class Program
  {
    [TestMethod]
    public void IsMain_CreatesTotalOrder_ReturnTotalPrice()
    {
      Bread testBread = new Bread();
      int breadOrder = testBread.BreadOrder(10);
      Pastry testPastry = new Pastry();
      int pastryOrder = testPastry.PastryOrder(6);
      int totalPrice = breadOrder + pastryOrder;
      Assert.AreEqual(totalPrice, 45);
    }
  }
}