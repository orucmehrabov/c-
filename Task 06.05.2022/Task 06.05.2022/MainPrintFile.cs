using System;
using System.Collections.Generic;
using System.Text;

namespace Task_06._05._2022
{
    class MainPrintFile
    {
        public MainPrintFile(IPrintable print)
        {
            print.PrintFile();
        }
    }
}