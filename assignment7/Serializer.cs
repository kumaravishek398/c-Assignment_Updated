 using System;
using System.IO;
 using System.Runtime. Serialization. Formatters.Binary;

namespace SerializeEmployee
{
 
 
 [Serializable]
public class Employee
{
public int Empno { get; set; }
public string Name { get; set; }
}

[Serializable]
public class MarketingExecutive
{
public string FirstName { get; set; }
public string LastName { get; set; }
}

[Serializable]
public class Manager
{
public string FirstName { get; set; }
public string Department { get; set; }
}


 class BinarySerializer
{
public void SerializeEmployee(object  source, string filePath)
{
FileStream fileStream;  
BinaryFormatter bf = new BinaryFormatter();
if (File. Exists(filePath)) 
File.Delete (filePath);   //if file exists then delete
fileStream = File.Create(filePath);     //create file to save the searilized data
bf.Serialize(fileStream, source);    //source=object which is being searilized
fileStream.Close();
}

      public void SerializeMarketingExecutive(object  source, string filePath)
{
FileStream fileStream;
BinaryFormatter bf = new BinaryFormatter();
if (File. Exists(filePath)) 
File.Delete (filePath);
fileStream = File.Create(filePath);
bf.Serialize(fileStream, source);
fileStream.Close();
}

public void SerializeManager(object  source, string filePath)
{
FileStream fileStream;
BinaryFormatter bf = new BinaryFormatter();
if (File. Exists(filePath))
 File.Delete (filePath);
fileStream = File.Create(filePath);
bf.Serialize(fileStream, source);
fileStream.Close();
}


}

class Serializer
{
   static void Main(String[] args)  //DRIVER CODE
   {

       Employee emp1=new Employee(){Empno=1,Name="Akash"};
      MarketingExecutive emp2=new  MarketingExecutive(){FirstName=1"Ankit",LastName="Aman"};
       Manager emp3=new Manager(){FirstName="Avishek",Department="Sales"};

       String filePath1="demo1.txt";
       String filePath2="demo2.txt";
       String filePath3="demo3.txt";

       BinarySerializer binarySerializer =new BinarySerializer();
     binarySerializer.SerializeEmployee(emp1,filePath1);
     binarySerializer.SerializeMarketingExecutive(emp2,filePath2);
     binarySerializer.SerializeManager(emp3,filePath3);
      
        
   }
    
}
}