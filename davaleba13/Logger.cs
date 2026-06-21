using System;
using System.Collections.Generic;
using System.Text;

namespace davaleba13
{
    public class Logger : IDisposable
    {
        public Logger()
        {
            Console.WriteLine("Logger Created");
        }
        public void Log(string message)
        {
            Console.WriteLine($"[LOG]: {message}");
        }
        public void Dispose()
        {
            Console.WriteLine("logger finished working");
        }

    }
}
