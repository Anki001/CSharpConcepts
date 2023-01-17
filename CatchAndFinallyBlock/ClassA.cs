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
                a++;
                throw new Exception("somethig is wrong");
            }
            catch
            {
                a = a + 1;
                return a;
            }
            finally
            {
                a = a + 1;
            }
        }
    }
}
