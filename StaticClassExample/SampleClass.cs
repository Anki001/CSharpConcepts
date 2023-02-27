using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassExample
{
    internal class SampleClass
    {
        private static string _name;

        static SampleClass()
        {
            _name = "Ankush";
        }        
    }
}
