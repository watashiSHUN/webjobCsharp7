using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp7consoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            setStr(out string a);
            Console.WriteLine(a);
            Console.ReadLine();
        }

        static void setStr(out string a)
        {
            a = "shun";
        }
    }
}
