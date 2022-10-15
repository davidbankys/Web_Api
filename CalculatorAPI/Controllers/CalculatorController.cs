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
        public double Add(double left, double right)
        {
            //using the calculator logic class to add 2 numbers
            double result = CalculatorLogic.Calculator.Add(left, right);

            //return added values in 2 decimal points
            return Math.Round(result, 2);
        }

        [HttpPost]
        public double Substract(double left, double right)
        {
            //using the calculator logic class to substract 2 numbers
            double result = CalculatorLogic.Calculator.SubstractNumbers(left, right);

            return Math.Round(result, 2);
        }

        [HttpPost]
        public double Multiply(double left, double right)
        {
            //using the calculator logic class to multiply 2 numbers
            double result = CalculatorLogic.Calculator.MultiplyNumbers(left, right);

            //return added values in 2 decimal points
            return Math.Round(result, 2);
        }

        [HttpPost]
        public double Divide(double left, double right)
        {
            double result = 0;

            //I am using the try and catch method here to catch any exception error throw from dividung any number by zero
            try
            {
                //using the  calculator logic class to divide 2 numbers
                result = CalculatorLogic.Calculator.DivideNumbers(left, right);
            }
            catch (DivideByZeroException)
            {
                //using dividebyzero exception to catch specific error and changing status code to 400
                Response.StatusCode = 400;
            }

            return Math.Round(result, 2);
        }
    }
}
