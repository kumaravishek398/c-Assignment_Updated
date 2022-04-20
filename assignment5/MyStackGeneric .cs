using System;


namespace CustomClass
{

    class GenericEmployeeClass<T>    
    {
           static int MAX = 5;     //declaring the size of the array

           int TOP=-1;             // variable to store top position
            
           String[] stack = new String[MAX]; //creating array of generic type


           internal void Push(String data)
        {
            if (TOP >= MAX)
            {       
                  Console.WriteLine("Stack Overflow : stack is already full");                                             
            }          
            else
            {
                stack[++TOP] = data;
                
            }
        }

         internal String Pop()
        {
            if (TOP< 0)
            {
               
            Console.WriteLine("Stack underflow : stack is empty");
                
                   return null;         
               
            }
            else
            {
                String value = stack[TOP--];
                return value;
            }
        }

        internal void Show()      //method to display the names in th array
      {
           Console.WriteLine("Names present in the stack");
           Console.WriteLine();
          for(int i=TOP;i>=0;i--)
          {
       Console.WriteLine("items present in stack {0}",stack[i]);
          }
 }  
 }

    public class MyStackGeneric  
    {

        
        static void Main(String[] args)    //DRIVER CODE
        {

           //creating custom generic class 
           GenericEmployeeClass<String> generic =new GenericEmployeeClass<String>();

        generic.Push("Avishek");
        generic.Push("Aman");
        generic.Push("Avneet");
        generic.Push("Virat");
        

         Console.WriteLine();
        Console.WriteLine("Names present after pushing");
           generic.Show(); 

        Console.WriteLine("Names removed from the stack {0}",generic.Pop());

        Console.WriteLine();

        Console.WriteLine(" after removing some names");
           generic.Show(); 

           Console.ReadKey();
        }
    }
}