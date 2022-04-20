using System;
using System.Collections;

namespace  ListOperation
{
     class Employee
     {
        protected int EId;
        protected String Name;
        protected double Salary;
        protected String Designation;

        public Employee()
     {

     }

        public int Id
        {  get{return EId;}
           set{  EId=value;}
        }
        public String EName
        {  get{return Name;}
           set{  Name=value;}
        }
        public double Sal
        {  get{return Salary;}
           set{  Salary=value;}
        }
        public String Job
        {  get{return Designation;}
           set{  Designation=value;}
        }

     }

    class ArraysList
    {
        static void Main(String[] args)
        {
               
               Console.WriteLine("Enter 3 employee details");

            Employee emp1=new Employee(){};      //creating employee object 
              
            //Taking details of employee by user
             Console.WriteLine("Enter ID");           
             emp1.Id=(Convert.ToInt32(Console.ReadLine())); 
             Console.WriteLine("Enter Name");    
             emp1.EName=(Console.ReadLine());
             Console.WriteLine("Enter Salary");   
             emp1.Sal=(Convert.ToDouble(Console.ReadLine()));
             Console.WriteLine("Enter job ");
             emp1.Job=(Console.ReadLine());      
             
               Console.WriteLine();

            Employee emp2=new Employee(){};

                  Console.WriteLine("Enter ID");       
             emp2.Id=(Convert.ToInt32(Console.ReadLine())); 
             Console.WriteLine("Enter Name");    
             emp2.EName=(Console.ReadLine());
             Console.WriteLine("Enter Salary");   
             emp2.Sal=(Convert.ToDouble(Console.ReadLine()));
             Console.WriteLine("Enter job ");
             emp2.Job=(Console.ReadLine());


             Console.WriteLine();

            Employee emp3=new Employee(){};

                 Console.WriteLine("Enter ID");       
             emp3.Id=(Convert.ToInt32(Console.ReadLine())); 
             Console.WriteLine("Enter Name");    
             emp3.EName=(Console.ReadLine());
             Console.WriteLine("Enter Salary");   
             emp3.Sal=(Convert.ToDouble(Console.ReadLine()));
             Console.WriteLine("Enter job ");
             emp3.Job=(Console.ReadLine());
               
         
         //Adding employee object to Arraylist and it is hetrogeneous
            ArrayList arraylist = new ArrayList();   
               arraylist.Add(emp1);
               arraylist.Add(emp2);
               arraylist.Add(emp3);

              Console.WriteLine();
              Console.WriteLine("Details of all the employees added");
              Console.WriteLine();

              foreach(Employee emp in arraylist)
              {
                  Console.WriteLine("Emploee ID : {0}",emp.Id);
                  Console.WriteLine("Emploee Name: {0}",emp.EName);
                  Console.WriteLine("Emploee Salary: {0}",emp.Sal);
                  Console.WriteLine("Emploee Designation: {0}",emp.Job);
                  Console.WriteLine("---------------------------------------");
              }
                      Console.ReadKey();
        }
    }
}