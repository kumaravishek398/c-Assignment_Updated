using System;

namespace StructureBook
{
    
        public struct Book
        {
          public  int bookId;
          public  string title;
          public  double price;
          public   enum bookType
            { Magazine, Novel, ReferenceBook, Miscellaneous }
        
        }
    class StructureBoook
    {
        static void Main(string[] args)
        {
            AcceptDetails();
        }
        public static void AcceptDetails()
        {
            Book b1;  //Reference of structure Book

            Console.WriteLine("Enter BookId");
            b1.bookId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter title");
            b1.title = Console.ReadLine();

            Console.WriteLine("Enter Price");
            b1.price = Convert.ToDouble(Console.ReadLine());
          //  Enum k = Book.bookType.Magazine;

            Console.WriteLine("Book Type :"+Book.bookType.Magazine);   //printing result
            Console.WriteLine("BookId :"+b1.bookId);
            Console.WriteLine("Book Title :"+b1.title);
            Console.WriteLine("Price :"+b1.price);

            Console.ReadKey();
           
        }
       
    }
}
