using System;

namespace UniCastDeligate
{

          public delegate void EmployeeDelegate();    //creating delegate

    class Manager{
         
        public int ID{get;set;}
        public String Name{get;set;}
        public double Salary{get;set;}
        public String Department{get;set;}

        public Manager()
        {

        }

       public void DisplayDetails()
        {
            Console.WriteLine("Manager ID: {0}",ID);
            Console.WriteLine("Manager name: {0}",Name);
            Console.WriteLine("Manager Salary: {0}",Salary);
            Console.WriteLine("Manager Department: {0}",Department);
        }
        

    }

class Employee{

    static void Main(String[] args)    //driver code
    {

        Manager manager=new Manager(){
       ID=1,Name="Avishek",Salary=500000,Department="Sales"      //using initiallizers
   };


   EmployeeDelegate callingDelegate=new EmployeeDelegate(manager.DisplayDetails);   //passing function as parameter

    callingDelegate();    //using delegate


    }


}

      

        

}
