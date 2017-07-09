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
    public class Tests
    {
        public IProgrammingTest _obj = null;
        public IRandomPinGenerator randomobj = null;
        public List<PinModel> model = new List<PinModel>();
        public IFibonacciCheck fiboCheck = null;

        [TestFixtureSetUp]
        public void Init()
        {
            _obj = new ProgrammingTest.ProgrammingTest();
            randomobj = new RandomPinGenerator();
            fiboCheck = new FibonacciCheck();
        }
        
        [TestFixtureTearDown]
        public void Close()
        {
            if (_obj != null)
                _obj = null;

            if (randomobj != null)
                randomobj = null;

            if (fiboCheck != null)
                fiboCheck = null;
        }
    }
    
}