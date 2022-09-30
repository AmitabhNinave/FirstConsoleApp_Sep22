using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public static class Class2
    {
        public static void NewMethod(this Class1 obj)
        {
            Console.WriteLine("Hello I m extended method");
        }

    }
}
