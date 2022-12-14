
using CalculatorLogic;
namespace CalculatorTest;


[TestClass]
public class UCalculatorTest
{
    [TestMethod]
    public void Add_Two_Positive_Integer()
    {
        int result = (int)CalculatorLogic.Calculator.Add(1, 1);
        Assert.AreEqual(2, result);
      
    }

    [TestMethod]
    public void Add_Two_Numbers_To_Get_A_Positive_Number_()
    {
        var result = CalculatorLogic.Calculator.Add(1, 22);
        Assert.AreEqual(23, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Add_Two_Negative_Whole_Numbers_And_Return_A_Double()
    {
        var result = CalculatorLogic.Calculator.Add(-2, -2);
        Assert.AreEqual(-4, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Add_One_Positive_And_Negative_Together_And_Return_A_Double()
    {
        var result = CalculatorLogic.Calculator.Add(22, -36);
        Assert.AreEqual(-14.0, result);
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
    public void Add_2_Positve_Point_1()
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
    public void Subtract_Zero_Number_And_Variable_To_Get_A_Negative_Number()
    {
        var result = CalculatorLogic.Calculator.SubstractNumbers(0, 32);
        Assert.AreEqual(-32, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Subtract_Two_Negative_Whole_Numbers_Correctly_And_Return_A_Negative_Nubmber()
    {
        var result = CalculatorLogic.Calculator.SubstractNumbers(-22, -2);
        Assert.AreEqual(-24, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Subtract_One_Positive_And_Negative_Correctly_And_Return_A_Positive_Double()
    {
        var result = CalculatorLogic.Calculator.SubstractNumbers(22, -42);
        Assert.AreEqual(20, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Subtract_One_Positive_Decimal_And_Positive_Whole_Number_Correctly_And_Return_A_Negative()
    {
        var result = CalculatorLogic.Calculator.SubstractNumbers(2.4, 30);
        Assert.AreEqual(-27.6, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }


    [TestMethod]
    public void Subtract_One_Positive_Decimal_And_Negative_Whole_Number_Correctly_And_Return_A_Double()
    {
        var result = CalculatorLogic.Calculator.SubstractNumbers(5.5, -30);
        Assert.AreEqual(24.5, result);
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
    public void Subtract_Two_Negative_Decimal_Numbers_Correctly_And_Return_A_Positive()
    {
        var result = CalculatorLogic.Calculator.SubstractNumbers(-2.2, -6.2);
        Assert.AreEqual(4.0, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Subtract_One_Positive_And_Zero_And_Return_A_Negative_Double()
    {
        var result = CalculatorLogic.Calculator.SubstractNumbers(0, 6);
        Assert.AreEqual(-6, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Subtract_Two_Positve_Whole_Numbers()
    {
        var result = CalculatorLogic.Calculator.SubstractNumbers(3.1, 1.1);
        Assert.AreEqual(2.0, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

   
    //This are Multiplication logic tests
    

    [TestMethod]
    public void Multiply_Two_Positive_Whole_Number_Correctly_And_Return_A_Positive_Double()
    {
        var result = CalculatorLogic.Calculator.MultiplyNumbers(3, 2);
        Assert.AreEqual(6, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Multiply_One_Number_And_Zero_To_Get_zero()
    {
        var result = CalculatorLogic.Calculator.MultiplyNumbers(0, 14);
        Assert.AreEqual(0, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Multiply_Two_Negative_Whole_Numbers_Correctly_And_Return_A_Negative_Nubmber()
    {
        var result = CalculatorLogic.Calculator.MultiplyNumbers(-2, -2);
        Assert.AreEqual(-4, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Multiply_One_Positive_And_Negative_Correctly_And_Return_A_Negative_Number()
    {
        var result = CalculatorLogic.Calculator.MultiplyNumbers(2, -4);
        Assert.AreEqual(-2, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Multiply_One_Positive_Decimal_And_Positive_Whole_Number_To_Return_A_Positive()
    {
        var result = CalculatorLogic.Calculator.MultiplyNumbers(2.4, 2);
        Assert.AreEqual(4.8, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }


    [TestMethod]
    public void Multiply_One_Positive_Decimal_And_Negative_Whole_Number_Correctly_And_Return_A_Negative_Double()
    {
        var result = CalculatorLogic.Calculator.MultiplyNumbers(5.5, -3);
        Assert.AreEqual(-16.5, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }


    [TestMethod]
    public void Multiply_Two_Zero_Numbers_And_Return_A_Zero()
    {
        var result = CalculatorLogic.Calculator.MultiplyNumbers(0, 0);
        Assert.AreEqual(0, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }


    [TestMethod]
    public void Multiply_Two_Negative_Decimal_Numbers_Correctly_And_Return_Negative()
    {
        var result = CalculatorLogic.Calculator.MultiplyNumbers(-2.5, -1.5);
        Assert.AreEqual(-4, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Multiply_One_Positive_And_Zero_Correctly_And_Return_A_Zero()
    {
        var result = CalculatorLogic.Calculator.MultiplyNumbers(0, 5);
        Assert.AreEqual(0, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Multiply_Two_Positve_Whole_Numbers()
    {
        var result = CalculatorLogic.Calculator.MultiplyNumbers(3.3, 1.1);
        Assert.AreEqual(3.63, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    //
    //This are Division logic tests
    //

    [TestMethod]
    public void Divide_Two_Positive_Number_Together_And_Return_A_Double()
    {
        var result = CalculatorLogic.Calculator.DivideNumbers(9, 1);
        Assert.AreEqual(9, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Divide_Zero_A_Positive_Number_To_Get()
    {
        var result = CalculatorLogic.Calculator.DivideNumbers(0, 2);
        Assert.AreEqual(0, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Divide_Two_Negative_Numbers_Together_To_Return_A_Double()
    {
        var result = CalculatorLogic.Calculator.DivideNumbers(-10, -2);
        Assert.AreEqual(5, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Divide_One_Positive_And_A_Negative_Together_To_Return_A_Double()
    {
        var result = CalculatorLogic.Calculator.DivideNumbers(15, -1);
        Assert.AreEqual(-15, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Divide_One_Positive_Double_And__Positive_Whole_Number_Together_To_Return_A_Double()
    {
        var result = CalculatorLogic.Calculator.DivideNumbers(4.4, 2);
        Assert.AreEqual(2.2, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }


    [TestMethod]
    public void Divide_One_Positive_Double_And_Negative_Whole_Number_Correctly_And_Return_A_Double()
    {
        var result = CalculatorLogic.Calculator.DivideNumbers(7.6, -3);
        Assert.AreEqual(4.6, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }


    [TestMethod]
    public void Divide_Two_Zero_Numbers_And_Return_AN_Exception_Error()
    {
        Assert.ThrowsException<DivideByZeroException>(() =>
        CalculatorLogic.Calculator.DivideNumbers(0, 0));
    }


    [TestMethod]
    public void Divide_Two_Negative_Decimal_Numbers_Correctly_And_Return_Negative()
    {
        var result = CalculatorLogic.Calculator.DivideNumbers(-2.2, -1.1);
        Assert.AreEqual(2, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Divide_One_Positive_And_Zero_Correctly_And_Return_A_Double()
    {
        var result = CalculatorLogic.Calculator.DivideNumbers(0, 5);
        Assert.AreEqual(0, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Divide_By_Zero_And_Return_A_Exception_Error()
    {
        Assert.ThrowsException<DivideByZeroException>(() =>
        CalculatorLogic.Calculator.DivideNumbers(2.1, 0));
    }



}
