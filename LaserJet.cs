using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismPrinterInterface
{
    class LaserJet : IPrinterWindows
    {
        public void Print()
        {
            Console.WriteLine("LaserJet display dimension : 12*12 ");
        }

        public void Show()
        {
            Console.WriteLine("LaserJet printer printing.......");
        }
    }
}
    

