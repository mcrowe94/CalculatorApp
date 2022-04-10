using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string userAnswer;
            int firstNumber = 0;
            int secondNumber = 0;

            Console.WriteLine("Welcome to your calculator! What function would you like to perform?");
            Console.WriteLine("1: Addition!\n2: Subtraction!\n3: Division!\n4: Multiplication!");
            userAnswer = Console.ReadLine();

            MainMenu(userAnswer, firstNumber, secondNumber);


        }

        public static void MainMenu(string userAnswer, int firstNumber, int secondNumber)
        {
            if (userAnswer == "1")
            {
                Console.WriteLine("What is the first number you'd like to add?");
                firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the second number you'd like to add?");
                secondNumber = Convert.ToInt32(Console.ReadLine());
                Sum(firstNumber, secondNumber);
            }
            else if (userAnswer == "2")
            {
                Console.WriteLine("What is the first number you'd like to subtract?");
                firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the second number you'd like to subtract?");
                secondNumber = Convert.ToInt32(Console.ReadLine());
                Subtract(firstNumber, secondNumber);
            }
            else if (userAnswer == "3")
            {
                Console.WriteLine("What is the first number you'd like to divide?");
                firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the second number you'd like to divide?");
                secondNumber = Convert.ToInt32(Console.ReadLine());
                Divide(firstNumber, secondNumber);
            }
            else if (userAnswer == "4")
            {
                Console.WriteLine("What is the first number you'd like to multiply?");
                firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the second number you'd like to multiply?");
                secondNumber = Convert.ToInt32(Console.ReadLine());
                Multiply(firstNumber, secondNumber);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Input :(");
            }

        }

        public static void Divide(int a, int b)
        {
            int answer = a / b;
            Console.WriteLine($"Your answer is: {answer}!");
        }

        public static void Subtract(int a, int b)
        {
            int answer = a - b;
            Console.WriteLine($"Your answer is: {answer}!");
        }

        public static void Sum(int a, int b)
        {
            int answer = a + b;
            Console.WriteLine($"Your answer is: {answer}!");
        }

        public static void Multiply(int a, int b)
        {
            int answer = a * b;
            Console.WriteLine($"Your answer is: {answer}!");
        }





    }
}

