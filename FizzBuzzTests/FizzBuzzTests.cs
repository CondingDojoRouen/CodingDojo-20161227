using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Econocom.CodingDojo;
using System.Linq;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        public string[] FizzBuzzGenerate
        {
            get
            {
                return FizzBuzz.Generate();
            }
        }
        [TestMethod]
        public void FizzBuzzNotEmpty()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsTrue(FizzBuzzGenerate.Length > 0);
        }

        [TestMethod]
        public void FizzBuzzReturnsArrayOfString()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsInstanceOfType(FizzBuzzGenerate, typeof(string[]));
        }

        [TestMethod]
        public void FizzBuzzReturnOneAsFirstElement()
        {
            //arrange
            //act
            //assert
            Assert.AreEqual("1", FizzBuzzGenerate[0]);
        }

        [TestMethod]
        public void FuzzBuzzReturnsAnArrayOfOneHundredElements()
        {
            //Arrange
            //Act
            //Assert
            Assert.AreEqual(100, FizzBuzzGenerate.Length);
        }

        [TestMethod]
        public void FizzBuzzReturnsFizzForTheThirdElement()
        {
            //arrange
            //act
            //assert
            Assert.AreEqual("Fizz", FizzBuzzGenerate[2]);
        }

        [TestMethod]
        public void FizzBuzzReturnsStringContainingFizzForAllMultipleOfThree()
        {
            //arrange
            //act
            //assert
            Assert.IsTrue(FizzBuzzGenerate.Where((o, index) => (index + 1) % 3 == 0).All(o => o.Contains("Fizz")));
        }

        [TestMethod]
        public void FizzBuzzReturnsStringContainingBuzzForAllMultipleOfFive()
        {
            //arrange
            //act
            //assert
            Assert.IsTrue(FizzBuzzGenerate.Where((o, index) => (index + 1) % 5 == 0).All(o => o.Contains("Buzz")));
        }

        [TestMethod]
        public void FizzBuzzReturnsNumberIfNotMultipleOf3Or5()
        {
            //arrange
            //act
            //assert
            Assert.IsTrue(FizzBuzzGenerate
                .Where((o, index) => o != (index + 1).ToString())
                .All(o => o.Contains("Fizz") || o.Contains("Buzz")));
        }

    }
}
