using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class Calculator
    {
        UserInterface ui = new UserInterface();
        Addition add = new Addition();
        Subtraction subtract = new Subtraction();
        Multiplication multiply = new Multiplication();
        Division divide = new Division();
        Exponentiation exponentiate = new Exponentiation();


        public double doOperation()
        {
            ui.getNumbersAndOperator();
            if (ui.operation == "+")
            {

                add.Operation(ui.firstNumber, ui.secondNumber);

            }

            else if (ui.operation == "-")
            {
                subtract.Operation(ui.firstNumber, ui.secondNumber);
            }

            else if (ui.operation == "*")
            {
                multiply.Operation(ui.firstNumber, ui.secondNumber);
            }

            else if (ui.operation == "/")
            {

                divide.Operation(ui.firstNumber, ui.secondNumber);

            }

            else if (ui.operation == "^")
            {
                exponentiate.Operation(ui.firstNumber, ui.secondNumber);
            }


            exitQuestion();
            return ui.firstNumber + ui.secondNumber;
            
        }

        public void exitQuestion()
        {
            Console.WriteLine("Press 1 to enter a new equation or 2 to exit");
            string endChoice = Console.ReadLine();
            if (endChoice == "1")
            {
                doOperation();
            }

            else if (endChoice == "2")

            {
                Console.WriteLine("Goodby!");
                Console.ReadKey();
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("That is not a valid option in this menu");
                exitQuestion();
            }

        }
    }
}



//Build an advanced calculator:
//    a.Take in one input that has at least two numbers and an operator
//   b.Calculate Addition, Subtraction, Multiplication, Division, Exponential
//   c. Display the result
//   d. Implement three design patterns

//   e.For an extra challenge, implement compound expressions, advanced operations (beyond the simple arithmetic binary operators), and dependency injection.
//  f.Use SOLID principles.