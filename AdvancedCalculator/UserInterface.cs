using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class UserInterface
    {
        public double firstNumber;
        public double secondNumber;
        public string operation;



        public double getFirstNumber()
        {

            Console.WriteLine("Type first number followed by the enter key");
            try
            {
                firstNumber = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("That is not a valid option in this menu.");
                getFirstNumber();

            }

            return firstNumber;

        }
        public double getSecondNumber()
        {
            Console.WriteLine("Type second number followed by the enter key");

            try
            {
                secondNumber = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("That is not a valid option in this menu.");
                getSecondNumber();

            }

            return secondNumber;
        }



        public string getOperation()
        {
            Console.WriteLine("Enter operator followed by enter key (press + to add, - to subtract, * to multiply, / to divide, or ^ for exponentiation");
            operation = Console.ReadLine();
            if ((operation != "+") && (operation != "-") && (operation != "*") && (operation != "/") && (operation != "^"))
            {
                Console.WriteLine("That is not a valid operation in this menu");
                getOperation();
            }

            return operation;

        }

        public void getNumbersAndOperator()
        {

            getFirstNumber();
            getOperation();
            getSecondNumber();

        }
    }
}

