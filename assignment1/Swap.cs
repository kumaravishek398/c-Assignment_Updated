using System;

namespace Swaping {
    class Swap{

        static void Main(String[] args )
        {
            Console.WriteLine("Enter First number");
            var num1=Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter Second number");
            var num2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before Swaping : ");
            Console.WriteLine("a = {0} , b = {1}",num1,num2);

            String result =SwapingLogic(num1,num2);  //calling method

            Console.WriteLine("After Swaping : ");  //printing the result
            Console.WriteLine(result);

            Console.ReadLine();

        }

        static String SwapingLogic(int a, int b)
        {
            int temp=a;
            a=b;
            b=temp;

            return "a = "+a +", b = "+b;
        }
    }
}
