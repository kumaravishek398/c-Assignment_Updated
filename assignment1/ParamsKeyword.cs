using System;
namespace ParamsArrayOfInteger{

    class ParamsKeyword{

        static void Main(String[] args){   //Driver code

         Console.WriteLine("Enter 4 numbers");
        var num1=Convert.ToInt32(Console.ReadLine());
        var num2=Convert.ToInt32(Console.ReadLine());
        var num3=Convert.ToInt32(Console.ReadLine());
        var num4=Convert.ToInt32(Console.ReadLine());

        var result=SumOfIntegers(num1,num2,num3,num4);   //calling method

        Console.WriteLine("Sum of all the integers entered is {0}", result);    //displaying result
             
             Console.ReadLine();
        }


      public static int SumOfIntegers(params int[] arr)  //containing params parameter
        {
         var sum=0;                                       //calculating sum
        for(int i=0;i<arr.Length;i++)
        {
            sum+=arr[i];
        }
        return sum;
        }
    
    }
}