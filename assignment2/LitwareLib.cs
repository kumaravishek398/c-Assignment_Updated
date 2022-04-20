
using System;

namespace EmployeeManagmentSystem
{

    class LitwareLib
    {
      
       static void Main(String[] args)     //DRIVER CODE
       {
    
     Employee emp=new Employee();     

     try
     {
        Console.WriteLine("Enter employee No.");
     emp.EmpNo= int.Parse(Console.ReadLine());

     Console.WriteLine("Enter employee Name");
    emp.EmpName=Console.ReadLine();

     Console.WriteLine("Enter employee Salary");
     emp.Salary= double.Parse(Console.ReadLine());
        
     }

     catch (FormatException e)
      {
    Console.WriteLine("Enter details in correct format");
      }



      Calculate_HRA_TA_DA(emp); //method for calculating HRA,TA,DA

      emp.GrossSalary=emp.Salary+emp.HRA +emp.DA +emp.TA;
      
      CalculateSalary(emp);  //method for calculating PF,TDS,NETSALARY

      Console.WriteLine("Gross salary {0}",emp.GrossSalary);  //printing result
       Console.WriteLine();
    }


    //Calculating HRA ,TA, DA ACCORDING TO SALARY
     static void Calculate_HRA_TA_DA(Employee emp)   
     {

     if(emp.Salary<5000)
   {
   emp.HRA=emp.Salary*(0.1);
    emp.TA=emp.Salary*(0.5);
    emp.DA=emp.Salary*(0.15 );
   }
  else if(emp.Salary<10000)
  {
   emp.HRA=emp.Salary*(0.15);
   emp.TA=emp.Salary*(0.1);
   emp.DA=emp.Salary*(0.2);
  }

  else if(emp.Salary<15000)
  {
    emp.HRA=emp.Salary*(0.2);
    emp.TA=emp.Salary*(0.15);
    emp.DA=emp.Salary*(0.25);
  }

   else if(emp.Salary<20000)
  {
    emp.HRA=emp.Salary*(0.25);
    emp.TA=emp.Salary*(0.2);
    emp.DA=emp.Salary*(0.3);
  }

  else if(emp.Salary>=20000)
  {
    emp.HRA=emp.Salary*(0.3);
    emp.TA=emp.Salary*(0.25);
    emp.DA=emp.Salary*(0.35);
  }

     }

    static void CalculateSalary(Employee emp)
    {
      emp.PF=emp.GrossSalary*(0.1);
      emp.TDS=emp.GrossSalary*(0.18);
      emp.NetSalary=emp.GrossSalary-(emp.PF+emp.TDS);
    }
   
    }
}