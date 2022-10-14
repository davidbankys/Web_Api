
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

    [TestMethod]
    public void Add_A_Number_And_Variable_To_Get_A_Positive_Number_Since_Variable_Defaults_To_Zero()
    {
        var result = CalculatorLogic.Calculator.Add(1, 32);
        Assert.AreEqual(33, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Add_Two_Negative_Whole_Numbers_Correctly_And_Return_A_Double()
    {
        var result = CalculatorLogic.Calculator.Add(-2, -2);
        Assert.AreEqual(-4, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Add_One_Positive_And_Negative_Correctly_And_Return_A_Double()
    {
        var result = CalculatorLogic.Calculator.Add(22, -36);
        Assert.AreEqual(-14, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Add_One_Positive_Double_And__Positive_Whole_Number_Correctly_And_Return_A_Double()
    {
        var result = CalculatorLogic.Calculator.Add((int)2.4, 20);
        Assert.AreEqual(22.4, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }


    [TestMethod]
    public void Add_One_Positive_Double_And_Negative_Whole_Number_Correctly_And_Return_A_Double()
    {
        var result = CalculatorLogic.Calculator.Add((int)5.5, -30);
        Assert.AreEqual(-24.5, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }


    [TestMethod]
    public void Add_Two_Zero_Numbers_And_Return_A_Zero()
    {
        var result = CalculatorLogic.Calculator.Add(0, 0);
        Assert.AreEqual(0, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }


    [TestMethod]
    public void Add_Two_Negative_Decimal_Numbers_Correctly_And_Return_Negative()
    {
        var result = CalculatorLogic.Calculator.Add((int)-2.2, (int)-4.2);
        Assert.AreEqual(-6.4, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Add_One_Positive_And_Zero_Correctly_And_Return_A_Double()
    {
        var result = CalculatorLogic.Calculator.Add(0, 5);
        Assert.AreEqual(5, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Add_Positve_2_Point_1()
    {
        var result = CalculatorLogic.Calculator.Add((int)2.1, (int)1.1);
        Assert.AreEqual(3.2, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    
    //Subtraction logic tests
    //

    [TestMethod]
    public void Subtract_Two_Positive_Whole_Number_Correctly_And_Return_A_Positive_Double()
    {
        var result = CalculatorLogic.Calculator.SubstractNumbers(13, 12);
        Assert.AreEqual(1, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Subtract_One_Number_And_Variable_To_Get_An_Negative_Number_Since_Variable_Defaults_To_Zero()
    {
        var result = CalculatorLogic.Calculator.SubstractNumbers(ed, 32);
        Assert.AreEqual(-32, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Subtract_Two_Negative_Whole_Numbers_Correctly_And_Return_A_Negative_Nubmber()
    {
        var result = CalculatorLogic.Calculator.SubstractNumbers(-22, -2);
        Assert.AreEqual(-20, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Subtract_One_Positive_And_Negative_Correctly_And_Return_A_Positive_Double()
    {
        var result = CalculatorLogic.Calculator.SubstractNumbers(22, -452);
        Assert.AreEqual(474, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Subtract_One_Positive_Decimal_And_Positive_Whole_Number_Correctly_And_Return_A_Negative()
    {
        var result = CalculatorLogic.Calculator.SubstractNumbers(2.4, 20);
        Assert.AreEqual(-17.6, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }


    [TestMethod]
    public void Subtract_One_Positive_Decimal_And_Negative_Whole_Number_Correctly_And_Return_A_Double()
    {
        var result = CalculatorLogic.Calculator.SubstractNumbers(5.5, -30);
        Assert.AreEqual(35.5, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }


    [TestMethod]
    public void Subtract_Two_Zero_Numbers_And_Return_A_Zero()
    {
        var result = CalculatorLogic.Calculator.SubstractNumbers(0, 0);
        Assert.AreEqual(0, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }


    [TestMethod]
    public void Subtract_Two_Negative_Decimal_Numbers_Correctly_And_Return_Positive()
    {
        var result = CalculatorLogic.Calculator.SubstractNumbers(-2.2, -4.2);
        Assert.AreEqual(2.0, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Subtract_One_Positive_And_Zero_Correctly_And_Return_A_Negative_Double()
    {
        var result = CalculatorLogic.Calculator.SubstractNumbers(0, 5);
        Assert.AreEqual(-5, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Subtract_Two_Positve_Whole_Numbers()
    {
        var result = CalculatorLogic.Calculator.SubstractNumbers(2.1, 1.1);
        Assert.AreEqual(1.0, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }


}
