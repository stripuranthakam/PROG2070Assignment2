using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070STA02
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInputMenu1 = "";
            int userInputMenu1Int = 0;
            bool menu1 = false;
            string triangleTypeMessage = "";

            Console.WriteLine("Sreekar Tripuranthakam's Assignment 2");
            Console.WriteLine("PROG2070 Quality Assurance");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Please select one of the following options (1 or 2)");
                Console.WriteLine("1. Please enter the triangle dimensions");
                Console.WriteLine("2. Exit");
                Console.WriteLine();
                userInputMenu1 = Console.ReadLine();
                int.TryParse(userInputMenu1, out userInputMenu1Int);

                if (userInputMenu1Int == 1)
                {
                    string measurementA = "";
                    int measurementAInt = 0;
                    string measurementB = "";
                    int measurementBInt = 0;
                    string measurementC = "";
                    int measurementCInt = 0;
                    Console.Clear();
                    Console.WriteLine("Please enter measurement A");
                    measurementA = Console.ReadLine();
                    int.TryParse(measurementA, out measurementAInt);
                    Console.WriteLine("Please enter measurement B");
                    measurementB = Console.ReadLine();
                    int.TryParse(measurementB, out measurementBInt);
                    Console.WriteLine("Please enter measurement C");
                    measurementC = Console.ReadLine();
                    int.TryParse(measurementC, out measurementCInt);

                    triangleTypeMessage = TriangleSolver.Analyze(measurementAInt, measurementBInt, measurementCInt);

                    Console.Clear();
                    Console.WriteLine(triangleTypeMessage);
                    Console.WriteLine();
                    Console.WriteLine("Press enter to return to main menu");
                    Console.ReadKey();
                    Console.Clear();

                    menu1 = true;
                }
                else if (userInputMenu1Int == 2)
                {
                    menu1 = false;
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Error found, please enter a valid numeric value");
                    Console.WriteLine();
                    menu1 = true;
                }
            } while (menu1);
        }
    }
}
