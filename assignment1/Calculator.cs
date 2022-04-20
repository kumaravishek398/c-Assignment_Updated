using  System;
namespace Calculator{

    class Calculator{
        static void Main(String[] args)
        {
       Console.WriteLine("Enter 1st number");
        var num1=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter 2nd number");
        var num2=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"addition of {num1} and {num2} is {num1 + num2}");   //using string interpolation
        Console.WriteLine($"Subtraction of {num1} and {num2} is {num1 - num2}");
        Console.WriteLine($"Multiplication of {num1} and {num2} is {num1 + num2}");
        Console.WriteLine($"Division of {num1} and {num2} is {num1 / num2:N3}");
          
           Console.ReadKey();
        }
    }
}
