using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneableExample
{
    internal class Person : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public object Clone()
        {
            return new Person
            {
                Name = this.Name,
                Age = this.Age
            };
        }
    }
}
