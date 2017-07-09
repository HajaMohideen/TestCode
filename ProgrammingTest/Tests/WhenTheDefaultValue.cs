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
    public class WhenTheDefaultValue : Tests
    {

        [Test]
        public void When_The_Default_Number_Be_Ten_when_empty_param_passed()
        {
            string _defaultValue = "10";
            string _result = string.Empty;

            _result = _obj.GetValueWithDefault("", true);
            Assert.AreEqual(_defaultValue, _result, "Error: Default value doesn't match.");
        }

        [Test]
        public void When_The_Default_Number_Be_Ten()
        {
            string _defaultValue = "10";
            string _result = string.Empty;

            _result = _obj.GetValueWithDefault(_defaultValue, true);
            Assert.AreEqual(_defaultValue, _result, "Error: Default value doesn't match.");
        }

        [Test]
        public void When_The_Number_Less_Than_Ten()
        {
            string _paramvalue = "8";
            string _result = string.Empty;

            _result = _obj.GetValueWithDefault( _paramvalue, true );
            Assert.AreEqual( _paramvalue, _result, "Error: Provided param and return value does not match" );
        }

        [Test]
        public void When_The_Number_Greater_Than_Ten()
        {
            string _paramvalue = "12";
            string _result = string.Empty;

            _result = _obj.GetValueWithDefault(_paramvalue, true);
            Assert.AreEqual( _paramvalue, _result, "Error: Provided param and return value does not match");
        }

        [Test]
        public void When_The_Number_Equal_To_Hundred()
        {
            string _paramvalue = "100";
            string _result = string.Empty;

            _result = _obj.GetValueWithDefault(_paramvalue, true);
            Assert.AreEqual(_paramvalue, _result, "Error: Provided param and return value does not match");
        }

        [Test]
        public void When_The_Number_Greater_Than_Hundred()
        {
            string _paramvalue = "112";
            string _result = string.Empty;

            _result = _obj.GetValueWithDefault(_paramvalue, true);
            Assert.AreEqual(_paramvalue, _result, "Error: Provided param and return value does not match");
        }

        [Test]
        public void When_Pin_Generated_Successfully()
        {
            bool _result = false;
            string _param = "8";

            _result = _obj.Init(_param, true);

            Assert.IsTrue(_result, "Error: Init function does not generated Pins.");

        }

        [Test]
        public void When_WritePin_Function_Generated_Successfully()
        {
            bool _result = false;
            int _param = 5;

            _result = _obj.WritePins(_param);

            Assert.IsTrue(_result, "Error: Write function does not generated Pins.");

        }


    }
}
