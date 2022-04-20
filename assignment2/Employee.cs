using System;

namespace EmployeeManagmentSystem
{
    class Employee
    {
        private int _empNo;
        private string _empName;
        private double _salary;
        private double _HRA;
        private double _TA;
        private double _DA;
        private double _PF;
        private double _TDS;
        private double _netSalary;
        private double _grossSalary;

  

  

        public int EmpNo   // property
  {
    get { return _empNo; }   // get method
    set { _empNo = value; }  // set method
  }


        public string EmpName   // property
  {
    get { return _empName; }   // get method
    set { _empName = value; }  // set method
  }

   public double Salary   // property
  {
    get { return  _salary; }   // get method
    set {  _salary = value; }  // set method
  }


 public double HRA   // property
  {
    get { return  _HRA; }   // get method
    set {  _HRA = value; }  // set method
  }

  public double TA   // property
  {
    get { return  _TA; }   // get method
    set {  _TA = value; }  // set method
  }

  public double DA   // property
  {
    get { return  _DA; }   // get method
    set {  _DA = value; }  // set method
  }

  public double PF  // property
  {
    get { return  _PF; }   // get method
    set {  _PF = value; }  // set method
  }

 public double TDS  // property
  {
    get { return  _TDS; }   // get method
    set {  _TDS = value; }  // set method
  }

  public double NetSalary  // property
  {
    get { return  _netSalary; }   // get method
    set {  _netSalary = value; }  // set method
  }

   public double GrossSalary  // property
  {
    get { return  _grossSalary; }   // get method
    set {  _grossSalary = value; }  // set method
  }



 
    } 
}
