using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest
{

    public class FibonacciCheck : IFibonacciCheck
    {

        public int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            try
            {
                for (int i = 0; i < n; i++)
                {
                    int temp = a;
                    a = b;
                    b = temp + b;
                }
            } catch(Exception ex) {
                throw ex;
            }
            return a;
        }

        public bool IsFibonacci(int random)
        {
            bool result = false;
            try
            {
                for (int index = 0; index < 21; index++)
                {                    
                    if (Fibonacci(index) == random)
                    {
                        result = true;
                        break;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            catch(Exception ex) {
                throw ex;
            }
            return result;
        }
    }
}
