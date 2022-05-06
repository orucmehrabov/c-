using System;
using System.Collections.Generic;
using System.Text;

namespace Task_06._05._2022
{
    class PDF : IPrintable
    {
        public void PrintFile()
        {
            Console.WriteLine("PDF was printed");
        }
    }
}