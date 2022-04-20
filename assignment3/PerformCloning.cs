using System;

namespace PushAndPop
{

class MyStack 
{
      int top=-1;    //position
      static int MAX=5;  // size

      int[] stack = new int[MAX];  //integer array

    public void Push(int data)      //adding elements
        {
            if (top< MAX)
            {
               stack[++top] = data;  
               
            }
            else
                Console.WriteLine("Stack overflow");

        }

             public int Pop()      // removing elements
             {
              if(top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                int value = stack[top--];     //removing the topmost element and reducing the size
                return value;
            }
             }
          
         public void PrintStack()   
          {  
            for (int i=top;i>=0;i--)    //following LIFO 
            {
                Console.WriteLine(stack[i]);

            }
            Console.WriteLine("Element present at the top position {0}",stack[top]);

          }

          

}
    class PerformCloning
    {
    static void Main(String[] args)
    {
        
      MyStack myStack=new MyStack();

      myStack.Push(10);
      myStack.Push(25);
      myStack.Push(1);
      myStack.Push(9);
      myStack.Push(15);
       
       
       Console.WriteLine("Elements present in the stack");
       myStack.PrintStack();

       
      Console.WriteLine("Element popped from the stack {0}",myStack.Pop());
      
      Console.WriteLine("Elements present in the stack after using pop method");
       myStack.PrintStack();

       Console.ReadKey();

    

    }
    }
}