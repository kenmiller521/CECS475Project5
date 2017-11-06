using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _475_Lab_4_Part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //menu system here?
            int choice = promptMenu();
        }
        public static int promptMenu()
        {
            Console.WriteLine("0) Exit the program");
            Console.WriteLine("1) Add new standard");
            Console.WriteLine("2) Update Standard");
            Console.WriteLine("3) Delete Standard");
            Console.WriteLine("4) Search Standard");
            Console.WriteLine("5) Display Students related to Standard");
            Console.WriteLine("6) Display all students");
            Console.WriteLine("7) Add new Student");
            Console.WriteLine("8) Update Student");
            Console.WriteLine("9) Delete Student");
            Console.WriteLine("10) Search Student");
            Console.WriteLine("11) Display All students");
            //request int input, return int
            return Convert.ToInt32(Console.ReadLine());
            //check for user input?

        }
        public static void parseChoice()
        {
            // maybe int not void - return

        }
    }
}


