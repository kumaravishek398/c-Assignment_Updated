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

       public void DisplayDetailsOfManager()
        {
            Console.WriteLine("Manager ID: {0}",ID);
            Console.WriteLine("Manager name: {0}",Name);
            Console.WriteLine("Manager Salary: {0}",Salary);
            Console.WriteLine("Manager Department: {0}",Department);
            Console.WriteLine("----------------------------------------------");
        }
  

    }

       class MarketingExecutive{

         public int ID{get;set;}
        public String Name{get;set;}
        public double Salary{get;set;}
        public String Department{get;set;}

        public MarketingExecutive()
        {

        }

        public void DisplayDetailsOfMarketingExecutive()
        {
            Console.WriteLine("MarketingExecutive ID: {0}",ID);
            Console.WriteLine("MarketingExecutive name: {0}",Name);
            Console.WriteLine("MarketingExecutive Salary: {0}",Salary);
            Console.WriteLine("MarketingExecutive Department: {0}",Department);

            Console.WriteLine("----------------------------------------------");
        }
       }

class MulticastDeligate{

    static void Main(String[] args)    //driver code
    {

      Manager manager=new Manager(){              //creating instance of manager class
       ID=1,Name="Avishek",Salary=500000,Department="Sales"      //using initiallizers
        };


      MarketingExecutive  executive=new MarketingExecutive(){               //creating instance of MarketingExecutive class
       ID=2,Name="Snehal",Salary=7500000,Department="IT"      //using initiallizers
   };
    


   EmployeeDelegate callingDelegate=new EmployeeDelegate(manager.DisplayDetailsOfManager);   //passing 1st function as parameter
               callingDelegate += executive.DisplayDetailsOfMarketingExecutive;       //passing 2nd function as parameter

    callingDelegate();    //using multicast delegate

    Console.ReadKey();


    }


}

      

        

}
