namespace CustomGenericClass
{
    internal class MyList<T> : IMyList<T>
    {
        private List<T> _items;
        
        public MyList(List<T> items)
        {
            _items = items;
        }

        public int Count => _items.Count;

        public void Add(T item)
        {
            _items.Add(item);
        }

        public T Get(int index)
        {
            return _items[index];
        }
    }
}
