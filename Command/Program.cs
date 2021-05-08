using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentController controller = new DocumentController();

            controller.Print(new Open());
            controller.Print(new Save());
            controller.Print(new Close());

        }
    }
}
