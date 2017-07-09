using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProgrammingTest;
using Moq;

namespace Tests
{

    [TestFixture]
    public class WhenRandomPinGenerates : Tests
    {

        int number = 12;

        [Test]
        public void When_Random_Number_Generated_Are_Uniqe()
        {        
            model = randomobj.Get(number); 
            CollectionAssert.AllItemsAreUnique(model, "Error: The random numbers are not unique. ");
        }

        [Test]
        public void When_Random_Numbers_Generated_Are_They_Four_Digit()
        {
            int max = 9999;

            model = randomobj.Get(number);

            var result = model.Max(o => o.RandomNumber);

            Assert.LessOrEqual( result, max, "Error: Ransom number not Four digit." );
        }


        [Test]
        public void When_Random_Numbers_Generated_At_Least_One_Value_Fibonacci()
        {
            bool hasFiboFound = false;

            List<int> fibonaocci = new List<int>();

            model = randomobj.Get(number);

            hasFiboFound = model.Where(o => o.IsFibonacci == true).Any();

            Assert.IsTrue(hasFiboFound, "Error: Fibonacci value not found.");
        }


        [Test]
        public void When_Random_Number_Generated_By_Get_Func()
        {
            int number = 12;

            List<PinModel> model = new List<PinModel>();

            IRandomPinGenerator randomobj = new RandomPinGenerator();

            model = randomobj.Get(number);
            
            Assert.AreEqual(number, model.Count, "Err: Function return value does not macth with provided input value. ");
        }

        [Test]
        public void When_Random_Number_Generated_Has_Type_Matched()
        {
            int number = 12;

            List<PinModel> model = new List<PinModel>();

            IRandomPinGenerator randomobj = new RandomPinGenerator();

            model = randomobj.Get(number);

            Assert.IsInstanceOf(typeof(IEnumerable<PinModel>), model, "Model type does not match");
            
        }


    }

}
