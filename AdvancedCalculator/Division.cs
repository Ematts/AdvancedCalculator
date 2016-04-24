using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class Division 
    {
        public double Operation(double firstNumber, double secondNumber)
        {
            double answer = 0;
            if (secondNumber != 0)
            {
                answer = firstNumber / secondNumber;
                Console.WriteLine(firstNumber + " / " + secondNumber + " = " + answer);
            }
            else
            {
                Console.WriteLine("You cannot divide by 0");
            }

            return answer;
        }
    }
}
