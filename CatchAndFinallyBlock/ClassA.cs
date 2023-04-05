using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchAndFinallyBlock
{
    public class ClassA
    {
	    int a = 1;
        public int DoSomething()
        {
            try
            {
                try
                {
                    a++;
                    throw new Exception("somethig is wrong");
                }
                catch (Exception)
                {
                    Console.WriteLine("Inner Catch");
                    throw; // if commented - Not all code path returns the value
                }
                finally
                {
                    Console.WriteLine("Inner Finally");
                }
            }
            catch
            {
                a = a + 1;
                Console.WriteLine("Outer Catch");
                return a;
            }
            finally
            {
                a = a + 1;
                Console.WriteLine("Outer Finally");
            }
        }
    }
}
