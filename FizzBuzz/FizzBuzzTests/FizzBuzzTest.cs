using System;
using System.Collections.Generic;
using FizzBuzzClassLibrary;
using NUnit.Framework;

namespace FizzBuzzTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void RunFizzBuzzWith1AsUpperBoundReturns1()
        {
            //Arrange
            FizzBuzz f = new FizzBuzz(1);
            string[] expected = new string[] { "1" };
            ;
            
            //Act
            string[] results = f.RunFizzBuzz();

            //Assert
            Assert.That(results, Is.EqualTo(expected));
        }

        [Test]
        public void RunFizzBuzzWith3AsUpperBoundReturnsExpectedResults()
        {
            //Arrange
            FizzBuzz f = new FizzBuzz(3);
            string[] expected = new string[] { "1", "2", "Fizz" };
            ;
            
            //Act
            string[] results = f.RunFizzBuzz();

            //Assert
            Assert.That(results, Is.EqualTo(expected));
        }

        [Test]
        public void RunFizzBuzzWith5AsUpperBoundReturnsExpectedResults()
        {
            //Arrange
            FizzBuzz f = new FizzBuzz(5);
            string[] expected = new string[] { "1", "2", "Fizz", "4", "Buzz" };
            ;

            //Act
            string[] results = f.RunFizzBuzz();

            //Assert
            Assert.That(results, Is.EqualTo(expected));
        }

        [Test]
        public void RunFizzBuzzWithCustomDivisorGiveCorrectResults()
        {
            //Arrange
            List<Divisor> customDivisors = new List<Divisor>()
            {
                new Divisor() { Number = 3, Message = "Apple"},
                new Divisor() { Number = 5, Message = "Banana"}
            };

            FizzBuzz f = new FizzBuzz(5, customDivisors);
            string[] expected = new string[] { "1", "2", "Apple", "4", "Banana" };
            ;

            //Act
            string[] results = f.RunFizzBuzz();

            //Assert
            Assert.That(results, Is.EqualTo(expected));
        }

        [Test]
        public void RunFizzBuzzWith2CustomDivisorTo10GivesCorrectResults()
        {
            //Arrange
            List<Divisor> customDivisors = new List<Divisor>()
            {
                new Divisor() { Number = 2, Message = "Apple"},
                new Divisor() { Number = 5, Message = "Banana"}
            };

            FizzBuzz f = new FizzBuzz(10, customDivisors);
            string[] expected =
                new string[] { "1", "Apple", "3", "Apple", "Banana", "Apple", "7", "Apple", "9", "AppleBanana" };
            ;

            //Act
            string[] results = f.RunFizzBuzz();

            //Assert
            Assert.That(results, Is.EqualTo(expected));
        }

        [Test]
        public void RunFizzBuzzWith3CustomDivisorsTo15GivesCorrectResults()
        {
            //Arrange
            List<Divisor> customDivisors = new List<Divisor>()
            {
                new Divisor() { Number = 2, Message = "Red"},
                new Divisor() { Number = 3, Message = "Green"},
                new Divisor() { Number = 5, Message = "Refactor"}
            };

            FizzBuzz f = new FizzBuzz(15, customDivisors);
            string[] expected =
                new string[] { "1", "Red", "Green", "Red", "Refactor", "RedGreen", "7", "Red", "Green", "RedRefactor", "11", "RedGreen", "13", "Red", "GreenRefactor" };
            ;

            //Act
            string[] results = f.RunFizzBuzz();

            //Assert
            Assert.That(results, Is.EqualTo(expected));
        }

        [Test]
        public void RunDefaultFizzBuzzWith54735699AsUpperBoundThrowsOutOfMemoryException()
        {
            //Arrange
            FizzBuzz f = new FizzBuzz(54735699);
            OutOfMemoryException expected = null;
            
            //Act
            try
            {
            string[] results = f.RunFizzBuzz();
            }
            catch (OutOfMemoryException ex)
            {
                expected = ex;
            }

            //Assert
            Assert.That(expected != null);
        }

        [Test]
        public void RunDefaultFizzBuzzWith54735698AsUpperBoundPasses()
        {
            //Arrange
            FizzBuzz f = new FizzBuzz(54735698);
            OutOfMemoryException expected = null;

            //Act
            try
            {
                string[] results = f.RunFizzBuzz();
            }
            catch (OutOfMemoryException ex)
            {
                if (ex != null)
                {
                    expected = ex;
                }
                
            }

            //Assert
            Assert.That(expected == null);
        }
    }
}
