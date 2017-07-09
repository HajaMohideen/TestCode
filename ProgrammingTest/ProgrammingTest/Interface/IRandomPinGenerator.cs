using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest
{
    public interface IRandomPinGenerator
    {
        List<PinModel> Get(int param_num);
        List<PinModel> GeneratePin(int param_num);
    }
}
