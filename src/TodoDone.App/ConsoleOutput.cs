using System;
using TodoDone.Core;

namespace TodoDone.App
{
    public class ConsoleOutput : IOutput
    {
        public void Send(string message) => Console.WriteLine(message);
    }
}