using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
     
            string[] answer = new string[3];


            try
            {
                Console.WriteLine("Please Enter index of array you you would like to read");
                var userInput = Console.Read();

                Console.WriteLine(answer[userInput]);
                Console.Read();

            }


            catch (Exception ex)
            {

                //Logger logger = LogManager.GetCurrentClassLogger();
                //logger.Debug("Hello World!");
                Logger logger = LogManager.GetLogger("databaseLogger");
                //Console.WriteLine();
                logger.Error(ex);

                Console.WriteLine(ex.Message);


                Console.ReadLine();

            }
            finally {

                Console.ReadLine();
            }

        
        }
    }
}
