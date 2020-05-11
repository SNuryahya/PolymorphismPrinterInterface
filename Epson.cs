using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismPrinterInterface
{
    class Epson : IPrinterWindows
    {
        public void Print()
        {
            Console.WriteLine("Epson display dimension : 10*11 ");
        }

        public void Show()
        {
            Console.WriteLine("Epson printer printing.......");
        }
    }
}
