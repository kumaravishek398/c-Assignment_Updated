
using  System;
namespace Average{

    class Average{
        static void Main(String[] args)
        {
         int[] marks=new int[5];
         double result2=0.0;

         Console.WriteLine("Enter marks of 5 students");

         for(int i=0;i<5;i++)  //taking marks from the user
         {
               marks[i]=Convert.ToInt32(Console.ReadLine());
         }
         
         foreach(int sum in marks)    //adding marks of all the students
        {
           result2+=sum;   
        }
         Console.WriteLine($"Average marks of five students is {result2/marks.Length}");
         
         int result=HighestMarks(marks);

         Console.WriteLine($"Highest marks obtained is {result} marks");
           Console.ReadKey();
        

        }

        static int HighestMarks(int[] marks)
        {
            int highest=marks[0];
            for(int i=0;i<marks.Length;i++)
            {
                if(marks[i]>highest)
                highest=marks[i];
            }
            return highest;
        }
    }
}
