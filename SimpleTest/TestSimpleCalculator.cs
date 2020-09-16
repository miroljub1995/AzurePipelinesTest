using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleLib;

namespace SimpleTest
{
  [TestClass]
  public class TestSimpleCalculator
  {
    [TestMethod]
    public void TestShouldAddTwoNumbers()
    {
      SimpleCalculator calc = new SimpleCalculator();
      int actual = calc.Sum(2, 3);
      Assert.AreEqual(5, actual);
    }
  }
}
