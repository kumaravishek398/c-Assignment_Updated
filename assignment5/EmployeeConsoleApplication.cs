using System;
using System.Collections.Generic;
namespace LinkedListEmployee
{
    class Employee
    {
        private int _eid;
        private String _name;	
	    private double _salary;

       public  Employee()  //constructor
	    {
		}

         public int ID{
             get{return _eid;}
             set{_eid=value;}
         }
         public String Name{
             get{return _name;}
             set{_name=value;}
         }
         public double Salary{
             get{return _salary;}
             set{_salary=value;}
         }
    }



    class EmployeeConsoleApplication
    {
        //creating generic linkedlist with static keyword so that creating instance not required to access it
       static LinkedList<Employee> myList = new LinkedList<Employee>();   

       static void AddEmployee()
	{
           Console.WriteLine("Enter Eid");
           int eid=Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("Enter the name of the employee");
          String name=Console.ReadLine();

		  Console.WriteLine("Enter salary");
          double salary=Convert.ToDouble(Console.ReadLine());
    
		  Employee emp=new Employee(){ID=eid,Name=name,Salary=salary};
		  myList.AddFirst(emp);

          Console.WriteLine("Employee added succesfully");


    }

    static void DisplayDetails()
	{
		
       foreach( Employee obj in myList )
		{     
			Console.WriteLine("Employee id :"+obj.ID);
			Console.WriteLine("Employee name :"+obj.Name);
			Console.WriteLine("Employee salary :"+obj.Salary);
			Console.WriteLine();

		}	
	}

      static void  NoOfEmployee()
      {
          
        Console.WriteLine("No of Employee present in employee list : {0}",myList.Count);

      }


    static void SearchEmployee()
	{
		Console.WriteLine("Enter name to find the employee :");

	   String name2=Console.ReadLine();

	    foreach( Employee obj in myList )
		{
			if (name2.Equals(obj.Name))    //we can also use contains() here
			
		Console.WriteLine("{0}  is present in the employee list",name2);
						
            
		} 

	}

    

         static void Main(String[] args)        //DRIVER CODE
         {
           
        while(true)
		{
		Console.WriteLine("Press 1 to add/create an employee ");
		Console.WriteLine("Press 2 to display details of an employee ");
		Console.WriteLine("Press 3 to display no. of employee in the list ");
		Console.WriteLine("Press 4 to search an employee ");
		    
        int choice=Convert.ToInt32(Console.ReadLine());

           if (choice==1)
		{
			AddEmployee();
		}


        else if (choice==2)
		{
			DisplayDetails();

		}
        
        else if (choice==3)
		{
			NoOfEmployee();

		}

        else if (choice==4)
		{
			SearchEmployee();

		}


        

        Console.WriteLine("Press 1 to continue ");
		Console.WriteLine("Press any other number to stop ");

		int choice2=Convert.ToInt32(Console.ReadLine());

		if (choice2!=1)
		{
			break;
		}
	}


         }
    }
}