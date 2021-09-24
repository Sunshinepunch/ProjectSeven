using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void IsBreadOrder_CreatesBreadOrder_True()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(true, testBread.BreadOrder(20));
    }

    [TestMethod]
    public void IsMain_CreatesGreeting_True()
    {
      Bread testBread = new Bread();
      Assert.AreEqual("Welcome to Fresh Dawn Bakery!", testBread.Main());
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