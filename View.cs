using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RepChar
{
    class View
    {
        public void DisplayResults(string displayMe)
        {
            Console.Clear();
            Console.WriteLine("Your request:");
            Console.WriteLine();
            Console.Write(displayMe);
            Thread.Sleep(1000);
        }
    }
}
