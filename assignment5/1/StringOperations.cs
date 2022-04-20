
using System;

namespace  Operation
{
    class StringOperations
    {
        static void Main(String[] args)
        {
              String[] stringArray=new String[]{"Adam","Takeshi","Sneha","Avishek","Dilip"};
           
            //creating a new array to store the elements of previous array 
              String[] copyArray=new String[stringArray.Length];
             
             //using copy method of array to copy all the elements by using source and destination array
            Array.Copy(stringArray,0,copyArray,0,stringArray.Length);  

             Console.WriteLine("Original array...");
             foreach(String original in stringArray)
               {
                   Console.WriteLine(original);
               }
                 
                 Console.WriteLine("Copied array...");
             foreach(String Copied in copyArray)
               {
                   Console.WriteLine(Copied);
               }



               Array.Sort(stringArray);

              Console.WriteLine("Arrays in ascending order");
               foreach(String asc in stringArray)
               {
                   Console.WriteLine(asc);
               }
               

               Array.Reverse(stringArray);
             Console.WriteLine("Array in descinding order");
               foreach(String desc in stringArray)
               {
                   Console.WriteLine(desc);
               }

          //using clear method does not reduces the size it will take default values of array type      
               Array.Clear(stringArray,0,3);   
               Console.WriteLine("Element present in array after using clear method ");
                foreach(String present in stringArray)
               {
                   Console.WriteLine(present);
               }
               Console.ReadKey();

        }
    }
    
}
