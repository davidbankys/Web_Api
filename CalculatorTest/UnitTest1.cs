
using CalculatorLogic;
namespace CalculatorTest;


[TestClass]
public class UCalculatorTest
{
    [TestMethod]
    public void Add_Two_Positive_Integer()
    {
        int result = Calculator.Add(1, 1);
        Assert.AreEqual(2, result);
    }
}
