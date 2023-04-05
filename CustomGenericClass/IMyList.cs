namespace CustomGenericClass
{
    internal interface IMyList<T>
    {
        void Add(T item);
        T Get(int index);
        int Count { get; }
    }
}
