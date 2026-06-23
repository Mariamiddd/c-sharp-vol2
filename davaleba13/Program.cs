using System;

namespace davaleba13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            using (Logger appLogger = new Logger())
            {
                appLogger.Log("program started");

                var manager = new StudentManager();
                manager.RunMenu();

                appLogger.Log("program finished");
            }
        }
    }
}
