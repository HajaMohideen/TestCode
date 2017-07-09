using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using ProgrammingTest;

namespace Tests
{
    
    [TestFixture]
    public class WhenTheRandomNumbersAreFibonacci : Tests
    {


        [Test]
        public void When_The_Provided_One_Digit_Value_Is_Fibonacci()
        {
            int param = 5;

            var result = fiboCheck.IsFibonacci(param);

            Assert.AreEqual(true, result, "Error: Value is not Fibonacci.");

        }

        [Test]
        public void When_The_Provided_Two_Digit_Value_Is_Fibonacci()
        {
            int param = 21;

            var result = fiboCheck.IsFibonacci(param);

            Assert.AreEqual(true, result, "Error: Value is not Fibonacci.");

        }


        [Test]
        public void When_The_Provided_Three_Digit_Value_Is_Fibonacci()
        {
            int param = 233;

            var result = fiboCheck.IsFibonacci(param);

            Assert.AreEqual(true, result, "Error: Value is not Fibonacci.");

        }

        [Test]
        public void When_The_Provided_Value_Is_Not_Fibonacci()
        {
            int param = 123;

            var result = fiboCheck.IsFibonacci(param);

            Assert.AreEqual(false, result, "Error: Value is Fibonacci.");

        }
    }
}
