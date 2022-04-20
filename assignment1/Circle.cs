using System;
namespace CalculateAreaAndCircumference{

    class Circle{

        static void Main(String[] args){   //Driver code

        Console.WriteLine("Enter the radius of the circle");
        double radius=Convert.ToDouble(Console.ReadLine());

         double area=0,circumference=0;

          AreaAndCircumferenceOfCircle(radius ,out area, out circumference);    //method calling

        Console.WriteLine($"Area of circle is {area:N3}");          
        Console.WriteLine($"Circumference of circle {circumference:N3}");
        Console.ReadLine();
        }

        public static void AreaAndCircumferenceOfCircle(double r, out double area, out double circumference )  //using out keyword in parameter
        {
            area=3.14*r*r;
             circumference=2*3.14*r;

              
        }
    }
}