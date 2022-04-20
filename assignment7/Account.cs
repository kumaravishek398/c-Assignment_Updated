using System;
using System.IO;

namespace AcceptInformation
{
    class Account
    {
        public  String Name{get;set;}
        public  String BankName {get;set;}
        public  double AccountNo{get;set;}
        public  String AccountType{get;set;}

        public Account()
        {

        }
        
    }

    class Customer
    {

         

        static void Main(String[] args)
        {
       

            CustomerInformation();//taking information from user input
             CreateWriteReadFile();  //writinging the file
             ReadFile();



        }
    
              public static void CustomerInformation()
              {
                  Account account=new Account();
            
            Console.WriteLine("Enter your details");
            Console.WriteLine("Enter name");
             account.Name  =Console.ReadLine();

            Console.WriteLine("Enter Bank name");
            account.BankName= Console.ReadLine();

             Console.WriteLine("Enter Bank Accountno");
           account.AccountNo= Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Enter Account type");
             account.AccountType= Console.ReadLine();
              
               
              

             

              }

              public static void CreateWriteReadFile()
        {
            Account account1=new Account();
                                                      //path have to create manually
               FileInfo fileInfo = new FileInfo(@"D:\write\sample.txt");  
               StreamWriter write = fileInfo.CreateText();  
                  write.WriteLine("Name: {0} ",account1.Name);       //writing in the txt file
                   write.WriteLine("BankName: {0}",account1.BankName);
                   write.WriteLine("AccountNo: {0}",account1.AccountNo);
                   write.WriteLine("AccountType: {0}",account1.AccountType); 
                   write.WriteLine("Customer details added succesfully"); 
                   write.Close(); 

             
           }


    public static void ReadFile()
{
StreamReader read = new StreamReader (@"G:\write\test.txt"); //creating object of StreamReader class and giving path as parameter
Console.WriteLine(read.ReadToEnd());  //reading employee information
}
    }
}