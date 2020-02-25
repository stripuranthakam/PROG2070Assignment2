using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PROG2070STA02.Tests
{
    public class TriangleSolverTest
    {
        [Test]

        public void Analyze_Given444_ResultIsEquilateral()
        {
            //Arrange
            string equilateral;
            //Act
            equilateral = TriangleSolver.Analyze(4, 4, 4);
            //Assert
            Assert.AreSame("You have an equilateral triangle", equilateral);
        }

        [Test]
        public void Analyze_Given445_ResultIsIsosceles()
        {
            //Arrange
            string isosceles;
            //Act
            isosceles = TriangleSolver.Analyze(4, 4, 5);
            //Assert
            Assert.AreSame("You have a isosceles triangle", isosceles);
        }

        [Test]
        public void Analyze_Given356_ResultIsScalence()
        {
            //Arrange
            string scalene;
            //Act
            scalene = TriangleSolver.Analyze(3, 5, 6);
            //Assert
            Assert.AreSame("You have a scalene triangle", scalene);
        }

        [Test]
        public void Analyze_Given121_ResultIsNotValid()
        {
            //Arrange
            string notValid;
            //Act
            notValid = TriangleSolver.Analyze(1, 2, 1);
            //Assert
            Assert.AreSame("Numbers inputted do not make a triangle.. Please try again!", notValid);
        }

        [Test]
        public void Analyze_Given333_ResultIsValid()
        {
            //Arrange
            string valid;
            //Act
            valid = TriangleSolver.Analyze(3, 3, 3);
            //Assert
            Assert.AreNotSame("Numbers inputted do not make a triangle.. Please try again!", valid);
        }

        [Test]
        public void Analyze_Given033_ResultZeroFound()
        {
            //Arrange
            string checkForZero;
            //Act
            checkForZero = TriangleSolver.Analyze(0, 3, 3);
            //Assert
            Assert.AreSame("You can only enter numbers greater than 0. Please try again", checkForZero);
        }
    }
}
