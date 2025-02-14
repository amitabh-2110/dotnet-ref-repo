using System;

namespace CSharpCourse._1Basics;

public class CalculatorAssignment
{
    public static void CalculatorAssignmentMainMethod()
    {
        Console.WriteLine("Hello");

        Console.WriteLine("Input the first number: ");
        var userFirstNumber = Console.ReadLine();
        int firstNumber = int.Parse(userFirstNumber ?? "0");

        Console.WriteLine("Input the second number: ");
        var userSecondNumber = Console.ReadLine();
        int secondNumber = int.Parse(userSecondNumber ?? "0");

        Console.WriteLine("What do you want to do with those number?");
        Console.WriteLine("A S M");
        var userOperation = Console.ReadLine()?.Trim().ToLower();
        if(userOperation == "a")
        {
            PrintMessage(firstNumber, secondNumber, firstNumber + secondNumber, "+");
        }
        else if(userOperation == "s") 
        {
            PrintMessage(firstNumber, secondNumber, firstNumber - secondNumber, "-");
        }
        else if(userOperation == "m")
        {
            PrintMessage(firstNumber, secondNumber, firstNumber * secondNumber, "*");
        }
        else
        {
            Console.WriteLine("invalid operation");
        }

        static void PrintMessage(int firstNum, int secondNum, int res, string op)
        {
            Console.WriteLine(firstNum + op + secondNum + " = " + res);
        }

        Console.WriteLine("Press any key to close ..");
        Console.ReadKey();
    }
}
