using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7_P2_CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Custom Exceptions *****\n");

            #region System-Level Excpetions

            //NullReferenceException nullReferenceExp = new NullReferenceException();
            //Console.WriteLine(" NullReferenceException is-a SystemException? : {0}", nullReferenceExp is SystemException);

            #endregion

            #region Catch a custom exception

            Car SuzukiFX = new Car("Suzuki-FX", 90);
            try
            {
                // Trip exception.
                SuzukiFX.Accelerate(50);
            }
            catch (CarIsDeadException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ErrorTimeStamp);
                Console.WriteLine(e.CauseOfError);
            }
            
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    //Console.WriteLine(e.ErrorTimeStamp);
            //    //Console.WriteLine(e.CauseOfError);
            //}
            
            #endregion

            Console.ReadLine();
        }
    }
}
