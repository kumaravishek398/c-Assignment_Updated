using System;

namespace CustomException
{   


    class StackException : Exception                       //creating custom exception class
    {
        public StackException(String message) : base(message)
        {

        }

    }

class Stack
    {

        static int MAX = 5;     //declaring the size of the array

         int TOP=-1;             // variable to store top position

         int[] stack = new int[MAX]; 

       internal void Push(int data)
        {
            if (TOP >= MAX-1)
            {       
                   throw new StackException("Stack Overflow Exception: stack is already full");                                             
            }          
            else
            {
                stack[++TOP] = data;
                
            }
        }


    internal int Pop()     
        {
            if (TOP< 0)
            {
               
            throw new StackException("Stack underflow Exception: stack is empty");
                
                   return 0;         
               
            }
            else
            {
                int value = stack[TOP--];
                return value;
            }
        }

    #region Method to show the elements prestent in stack
      internal void Show()    
      {
           Console.WriteLine("Elemetnts present in the stack");
          for(int i=TOP;i>=0;i--)
          {
       Console.WriteLine("items pushed {0}",stack[i]);
          }


      }
      #endregion

    static void Main(String[] args)     //driver code
    {  
        Stack myStack = new Stack();
         Console.WriteLine("program starts....");
         Console.WriteLine();

        myStack.Push(5);
        myStack.Push(8);
        myStack.Push(10);
        myStack.Push(18);
        myStack.Push(9); 
          
         myStack.Show(); 
         
        Console.WriteLine("Element present at the top position {0}", myStack.stack[myStack.TOP]);       //

         Console.WriteLine();

           try  {                         //exception handelling for stack overflow
               myStack.Push(7);          //

                 }
            catch (StackException ex)
                {
      
                 Console.WriteLine(ex.Message);

                }

              

    Console.WriteLine();
      
      Console.WriteLine("Element popped from the stack {0}",myStack.Pop());
      Console.WriteLine("Element popped from the stack {0}",myStack.Pop());
      Console.WriteLine("Element popped from the stack {0}",myStack.Pop());
      Console.WriteLine("Element popped from the stack {0}",myStack.Pop());
      Console.WriteLine("Element popped from the stack {0}",myStack.Pop());

      Console.WriteLine();
      
            try  {                         //exception handelling for stack underflow
               myStack.Pop();  //

                 }
            catch (StackException ex)
                {
      
                 Console.WriteLine(ex.Message);

                }

                Console.WriteLine();
     
        Console.WriteLine("program ends");

         Console.ReadKey();
  

    }

       


    }
}