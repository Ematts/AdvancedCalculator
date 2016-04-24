using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class Addition 
    {
        public double Operation(double firstNumber, double secondNumber)
        {
            double answer = firstNumber + secondNumber;
            Console.WriteLine(firstNumber + " + " + secondNumber + " = " + answer);
            return answer;
        }
    }
}
