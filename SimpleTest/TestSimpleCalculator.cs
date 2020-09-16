using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleLib;

namespace SimpleTest
{
  [TestClass]
  public class TestSimpleCalculator
  {
    [TestMethod]
    public void TestShouldSumTwoNumbers()
    {
      SimpleCalculator calc = new SimpleCalculator();
      int actual = calc.Sum(2, 3);
      Assert.AreEqual(5, actual);
    }

    [TestMethod]
    public void TestShouldSubTwoNumbers()
    {
      SimpleCalculator calc = new SimpleCalculator();
      int actual = calc.Sub(3, 2);
      Assert.AreEqual(1, actual);
    }
  }
}
