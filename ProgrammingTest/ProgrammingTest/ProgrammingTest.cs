using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest
{    
    public class ProgrammingTest : IProgrammingTest
    {

        public static void Main()
        {
            string _defaultValue = "10";
            IProgrammingTest obj = new ProgrammingTest();
            obj.Init(_defaultValue);
            Console.ReadKey();            
        }

        public string GetValueWithDefault(string _defaultValue, bool isTest = false)
        {
            return Util.ReadLineWithDefault(_defaultValue, isTest);
        }

        public bool Init(string _defaultValue, bool isTest = false)
        {
            bool _result = false;

            try
            {
                Console.Write("Number of PINs to generate: ");
                string value = GetValueWithDefault( _defaultValue, isTest);
                _result = WritePins( Convert.ToInt32(value) );                
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return _result;
        }

        public bool WritePins(int param)
        {
            bool hasPinGenerated = false;
            
            IRandomPinGenerator obj = null;

            try
            {
                
                obj = new RandomPinGenerator();

                if (param <= 100)
                {                    
                    foreach ( var model in obj.Get(param) )
                    {
                        if (!model.IsFibonacci) {
                            Console.WriteLine(model.RandomNumber.ToString("0000"));
                        }
                        else {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(model.RandomNumber.ToString("0000"));
                            Console.ResetColor();
                            hasPinGenerated = true;
                        }                        
                    }
                }
                else
                {
                    hasPinGenerated = false;
                    Console.WriteLine("Err: System only generate PINs for the maximum number of 100. \n ");                    
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return hasPinGenerated;
        }
    }
 }

