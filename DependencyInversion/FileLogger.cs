namespace DependencyInversion
{

    interface ILogger
    {
        void Handle(string error);
    }

    internal class FileLogger: ILogger
    {
        public void Handle(string error)
        {
            // log error to event viewer
        }
    }    

    class EverViewerLogger : ILogger
    {
        public void Handle(string error)
        {
            // log errors to event viewer
        }
    }

    class EmailLogger : ILogger
    {
        public void Handle(string error)
        {
            // send errors in email
        }
    }
}
