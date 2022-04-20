using System;

namespace Hierarchy
{


interface IPrintable   //interface
{
    void Print();
}

    class Employee : IPrintable   //Base class
    {

         

      public virtual void CalculateSalary()   //overriding
        {
            Console.WriteLine("from employee class");
        }
         public virtual void Print()    //overriding print method of IPrintable interface
          {
             Console.WriteLine("printInterface"); 
              
          }
        

    }

    class Manager : Employee    //derrived class
    {
    private double _salary;
    private double _petrolAllowance;
	private double _foodAllowance ;
	private double _otherAllowances ; 
    private double _grossSalary ; 
     
      public Manager(double Salary)    //parameterized constructor of Manager class
      {
       _salary=Salary;
       _petrolAllowance=Salary*0.08;
	   _foodAllowance=Salary*0.13;
	   _otherAllowances=Salary*0.03;
       _grossSalary=_petrolAllowance+_foodAllowance+_otherAllowances;
      }

         

    
    //override
   public override void CalculateSalary()
        {
            double NetSalary=_salary-_petrolAllowance+_foodAllowance +_otherAllowances;
            double PF=NetSalary*0.1;
             Console.WriteLine("NetSalary={0} ,PF={1}",NetSalary,PF);
        }
        public override void Print()
          {
             Console.WriteLine("Designation :Manager ,PetrolAllowance: {0}, FoodAllowance:{1} ,OtherAllowances:{2} ",_petrolAllowance,_foodAllowance,_otherAllowances); 
              
          }
          
    }

    class MarketingExecutive : Employee   //2nd derrived class
    {
      private double _salary;
      private double _kilometertravel;
      private double _tourAllowances;
      private double _telephoneAllowances ;
      private double _grossSalary; 
      

      public  MarketingExecutive(double Salary,double Kilometertravel)
      {    
           _salary=Salary;
          _kilometertravel=Kilometertravel;
          _tourAllowances=5*Kilometertravel;
         _telephoneAllowances=1000;
         _grossSalary= _kilometertravel+_tourAllowances+_telephoneAllowances; 
      }

        

        //overriding CalculateSalary method of Employee class
        public override void CalculateSalary()    
        {
            double NetSalary=_salary-_kilometertravel+_tourAllowances +_telephoneAllowances ;
            double PF=NetSalary*0.1;
             Console.WriteLine("NetSalary={0} ,PF={1}",NetSalary,PF);
        }

        public override void Print()  //overriding print method of Employee class
          {
             Console.WriteLine("Designation :MarketingExecutive ,Kilometertravel:{0},TourAllowances:{1},TelephoneAllowances:{2} ",_kilometertravel,_tourAllowances,_telephoneAllowances,_grossSalary); 
            
          }

    }

    class HierarchyClass
    {
      
       static void Main(String[] args)     //DRIVER CODE
       {
           IPrintable e1=new Manager(5000);  //object created in manager class
           e1.Print();
          ((Employee)e1).CalculateSalary();     //Downcasting to employee type
             Console.WriteLine("-------------------------"); 
          IPrintable e2=new MarketingExecutive(7000,15);//object created in MarketingExecutive class
      
           e2.Print();
           ((Employee)e2).CalculateSalary();
       }
    }
}