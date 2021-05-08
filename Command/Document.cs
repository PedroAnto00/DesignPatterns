using System;

namespace Command
{
    public interface ICommand
    {
        public void Execute();
    }

    public class DocumentController
    {
        public void Print(ICommand doc)
        {
            doc.Execute();
        }
    }
    public class Open : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Document Opened");
        }
    }

    public class Save : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Document Saved");
        }
    }

    public class Close : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Document Closed");
        }
    }
}