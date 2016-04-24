using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class Exponentiation 
    {
        public double Operation(double firstNumber, double secondNumber)
        {
            double answer = (double)Math.Pow(firstNumber, secondNumber);
            Console.WriteLine(firstNumber + " ^ " + secondNumber + " = " + answer);
            return answer;

        }
    }

}