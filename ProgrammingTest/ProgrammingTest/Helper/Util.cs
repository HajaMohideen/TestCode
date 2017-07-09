using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest
{
    public static class Util
    {
        public static string _default = "10";

        public static int GetRandomNumber(int min, int max)
        {
            int value = 0;
            Random random = null;

            try
            {
                random = new Random();
                value = random.Next(min, max);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return value;
        }

        public static string ReadLineWithDefault(string defaultValue, bool isTest = false )
        {
            try
            {
                string read = isTest ? "" : Console.ReadLine();
                if (read != "")
                {
                    return read;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return String.IsNullOrEmpty(defaultValue) ? _default : defaultValue;
        }

    }
}
