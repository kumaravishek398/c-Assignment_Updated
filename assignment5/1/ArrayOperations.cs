using System;


namespace  Operation
{
    class ArrayOperations
    {
        static void Main(String[] args)
        {
              int[] integerArray=new int[]{5,8,12,1,6};
           
            //creating a new array to store the elements of previous array 
              int[] copyArray=new int[integerArray.Length];
             
             //using copy method of array to copy all the elements by using source and destination array
            Array.Copy(integerArray,0,copyArray,0,integerArray.Length);  

             Console.WriteLine("Original array...");
             foreach(int original in integerArray)
               {
                   Console.WriteLine(original);
               }
                 
                 Console.WriteLine("Copied array...");
             foreach(int Copied in copyArray)
               {
                   Console.WriteLine(Copied);
               }



               Array.Sort(integerArray);

              Console.WriteLine("Arrays in ascending order");
               foreach(int asc in integerArray)
               {
                   Console.WriteLine(asc);
               }
               

               Array.Reverse(integerArray);
             Console.WriteLine("Array in descinding order");
               foreach(int desc in integerArray)
               {
                   Console.WriteLine(desc);
               }

          //using clear method does not reduces the size it will take default values of array type      
               Array.Clear(integerArray,0,3);   
               Console.WriteLine("Element present in array after using clear method ");
                foreach(int present in integerArray)
               {
                   Console.WriteLine(present);
               }
               Console.ReadKey();

        }
    }
    
}
