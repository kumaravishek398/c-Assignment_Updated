using System;
using System.IO;
namespace ReadAndWrite
{
    class ReadAndWriteTxt
    {
        static void Main(String[] args)
        {

          
           WriteFile();  //
           ReadFile();

           CreateWriteReadFile();
           CreateDirectory();//method to create directory

        }

public static void WriteFile()
{
StreamWriter write =new StreamWriter(@"E:\write\test.txt"); //creating object of StreamWriter class and giving path as parameter
write.WriteLine("Avishek");  //writing in the txt file
write.Close();  //closing the method
}


public static void ReadFile()
{
StreamReader read = new StreamReader (@"E:\write\test.txt"); //creating object of StreamReader class and giving path as parameter
Console.WriteLine(read.ReadToEnd());  //ReadToEnd() reads the entire document and prints in the console
read.Close();
}



#region using FileInfo class methods to read and write
public static void CreateWriteReadFile()
{
FileInfo fileInfo = new FileInfo(@"E:\write\sample.txt");  
StreamWriter streamWriter = fileInfo.CreateText();  //creating a file using fileinfo class

streamWriter.WriteLine("Sample created");   //writing some text

streamWriter.Close();

}
#endregion


// DirectoryInfo class is used to get information about a directory
     
     #region using DirectoryInfo class method to create a directory

     public static void CreateDirectory()
{
     DirectoryInfo dir = new DirectoryInfo (@"E:\SampleDir");
    if(dir.Exists)  //if true
 {
    Console.WriteLine("Directory already exists...");
    
  }
    else{
     dir.Create();
      Console.WriteLine("Directory created..");
    }
}
#endregion
        
    }
}

