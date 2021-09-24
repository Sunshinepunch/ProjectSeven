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