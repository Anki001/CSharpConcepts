using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericClass
{
    internal class MyList<T>
    {
        private List<T> _items;

        public MyList()
        {
            _items = new List<T>();
        }

        public void Add(T item)
        {
            _items.Add(item);
        }

        public T Get(int index)
        {
            return _items[index];
        }

        public int Count { get { return _items.Count; } }
    }
}
