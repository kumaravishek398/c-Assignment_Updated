using System;

namespace Transaction
{

class Account{

  private double _accountNumber;
  private String _customerName;
  private double _balance ;

  public double AccountNumber
  {
      get{return _accountNumber; }
      set{_accountNumber=value;}
  }

  public String CustomerName
  {
      get{return _customerName; }
      set{_customerName=value;}
  }

   public double Balance
  {
      get{return _balance; }
      set{_balance=value;}
  }

 public Account()
 {

 }

      public void Withdraw(double amt)
      {

         if(Balance==0)
          Console.WriteLine("Zero balance....");
         


          else if(Balance<amt)
          {
          Console.WriteLine("Low balance....");
          Console.WriteLine("You are short on {0} rupees ",amt-Balance);
          }
          else if(Balance>=amt)
          {
              Balance =Balance-amt;
              Console.WriteLine("Succesfully withdrawn: {0}",amt);
              Console.WriteLine("Remaining balance :{0}",Balance);
          }
       else
       Console.WriteLine("Enter valid credentials ");



      }

      public void Deposit(double amt)
      {
        if(amt>20)
        {
        Balance=Balance+amt;
        Console.WriteLine("{0} deposited Succesfully : {0}",amt);
        Console.WriteLine("Available balance :{0}",Balance);
        }

       else
       Console.WriteLine("Enter valid credentials ");
          
      }


    }

        class Bank
            {
                static void Main(String[] args)  //driver code
                {

                     Console.WriteLine("Welcome to canara bank net banking");

                    Account canara= new Account(){
                        AccountNumber=4551122,
                        CustomerName="Avishek",
                        Balance=500
                    };
                  
                   Console.WriteLine("Enter the amount you want to withdraw");
                   double amt= Convert.ToDouble(Console.ReadLine());
                   canara.Withdraw(amt);

                   Console.WriteLine("Enter the amount you want to Deposit");
                   double amt2= Convert.ToDouble(Console.ReadLine());
                   canara.Deposit(amt2);


                }
            }


    
}
