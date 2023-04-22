using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = "Taemour";
            var location = "Utah";

            Console.WriteLine("My name is " + name);
            Console.WriteLine("I am from " + location);
            Console.WriteLine(DateTime.Today.ToShortDateString());
            Console.WriteLine("Days until Christmas: " + (Convert.ToDateTime("12-25-23") - DateTime.Today).TotalDays);

            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("What is the width of the string? ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("What is the height of the string? ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");



            Console.ReadKey();

        }
    }
}
