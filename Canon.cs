using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismPrinterInterface
{
    class Canon : IPrinterWindows
    {
        public void Print()
        {
            Console.WriteLine("Canon display dimension : 9.5*12 ");
        }

        public void Show()
        {
            Console.WriteLine("Canon printer printing.......");
        }
    }
}
