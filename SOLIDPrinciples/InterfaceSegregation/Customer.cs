namespace InterfaceSegregation
{
    interface IDatabaseOperationV1
    {
        void Add();
    }

    interface IDatabaseOperationV2
    {
        void Read();
    }

    internal class CustomerWithWrite : IDatabaseOperationV1
    {
        public void Add()
        {
            
        }
    }

    internal class CustomerReadAndWrite : IDatabaseOperationV1, IDatabaseOperationV2
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }        
    }
}
