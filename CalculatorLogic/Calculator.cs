namespace CalculatorLogic;

public static class Calculator
{   //Adding method of 2 numbers
    public static int Add(int left, int right)
    {
        return left + right;
    }
    //subtracting method of 2 numbers
    public static double SubstractNumbers(double left, double right)
    {
        //return subtracted numbers
        return left - right;
    }

    //multiplying method of 2 numbers
    public static double MultiplyNumbers(double left, double right)
    {
        //return mutliplied numbers
        return left * right;
    }

    //division method of 2 numbers
    public static double DivideNumbers(double left, double right)
    {
        //checked if the 2nd number is zero so that you can catch the error
        //if not make the division
        if (left != 0)
        {
            return left / right;
        }
        else
        {
            throw new DivideByZeroException();
        }
    }
}
