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


  }

  // [TestClass]
  // public class PastryTests
  // {
  //  [TestMethod]
  //   public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
  //   {
  //     Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
  //   }
  // }
}