using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class TestExtensionMethod
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            obj.Display();
            obj.Print();
            obj.NewMethod();
            //
            Console.ReadKey();
        }
    }
}
