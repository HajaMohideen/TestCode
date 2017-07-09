using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ProgrammingTest
{

    public interface IProgrammingTest
    {
        string GetValueWithDefault(string _defaultValue, bool isTest = false);

        bool Init(string _defaultValue, bool isTest = false);

        bool WritePins(int param);
    }
}

