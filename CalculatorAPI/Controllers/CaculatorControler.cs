using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    //here defines the api route via the api of each api method
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpPost]
        public double Add(double right, double left)
        {
            //using the simple calculator logic class to add 2 numbers
            double result = CalculatorLogic.Calculator.AddNumbers(right, left);

            //return added values in 2 decimal points
            return Math.Round(result, 2);
        }

        [HttpPost]
        public double Substract(double num1, double num2)
        {
            //using the simple calculator logic class to substract 2 numbers
            double result = CalculatorLogic.Calculator.SubstractNumbers(right, left);

            return Math.Round(result, 2);
        }

        [HttpPost]
        public double Multiply(double num1, double num2)
        {
            //using the simple calculator logic class to multiply 2 numbers
            double result = CalculatorLogic.Calculator.MultiplyNumbers(right, left);

            //return added values in 2 decimal points
            return Math.Round(result, 2);
        }

        [HttpPost]
        public double Divide(double left, double right)
        {
            double result = 0;

            //I am using the try and catch method here to catch any exception error throw from diving any number by zero
            try
            {
                //using the  calculator logic class to divide 2 numbers
                result = CalculatorLogic.Calculator.DivideNumbers(left, right);
            }
            catch (DivideByZeroException)
            {
                //using dividebyzeo exception to catch specific error and changing status code to 400
                Response.StatusCode = 400;
            }

            return Math.Round(result, 2);
        }
    }
}
