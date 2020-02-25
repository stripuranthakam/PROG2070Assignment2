using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070STA02
{
    public static class TriangleSolver
    {
        public static string Analyze(int sideA, int sideB, int sideC)
        {
            bool triangleValidity;

            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                return "You can only enter numbers greater than 0. Please try again";
            }
            else
            {

                if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                {
                    triangleValidity = false;
                    return "Numbers inputted do not make a triangle.. Please try again!";
                }
                else
                {
                    triangleValidity = true;
                }

                if (triangleValidity == true && sideA == sideB && sideB == sideC && sideA == sideC)
                {
                    return "You have an equilateral triangle";
                }
                else if (triangleValidity == true && sideA != sideB && sideB != sideC && sideA != sideC)
                {
                    return "You have a scalene triangle";
                }
                else if (triangleValidity == true && sideA == sideB && sideB != sideC || sideA == sideC && sideB != sideA)
                {
                    return "You have a isosceles triangle";
                }
                else
                {
                    return "Ooops, something went wrong. Please try again!";
                }
            }
        }
    }
}
