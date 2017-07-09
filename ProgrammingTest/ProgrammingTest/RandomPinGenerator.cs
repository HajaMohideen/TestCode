using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest
{
    
    public class RandomPinGenerator : IRandomPinGenerator
    {        

        public List<PinModel> Get(int param_num)
        {            
            return GeneratePin( param_num );
        }

        public List<PinModel> GeneratePin(int param_num)
        {
            int temp = 0; bool isFibo = false; int random = 0;
            List<PinModel> models = null;
            IFibonacciCheck fiboCheck = null;

            try
            {
                models = new List<PinModel>();
                fiboCheck = new FibonacciCheck();

                for (int index = 0; index < param_num; index++)
                {
                    random = Util.GetRandomNumber(0, 9999);
                    temp = random;

                    if (models.Count >= 0)
                    {
                        var result = models.Where(o => o.RandomNumber == temp).Any();
                        if (index == param_num - 1)
                        {
                            isFibo = models.Where(o => o.IsFibonacci == true).Any();
                            if (!isFibo)
                            {                                
                                random = fiboCheck.Fibonacci(Util.GetRandomNumber(1, 21));
                            }
                        }
                        if (result)
                        {
                            index--; continue;
                        }
                        else
                        {                            
                            var value = fiboCheck.IsFibonacci(random);
                            models.Add(new PinModel { RandomNumber = random, IsFibonacci = value });
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return models;
        }
    }
}
    
