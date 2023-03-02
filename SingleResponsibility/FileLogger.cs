namespace SingleResponsibility
{
    internal class FileLogger
    {
        internal void Handle(string error)
        {
            File.WriteAllText(@"c:\error.txt", error);
        }
    }
}
