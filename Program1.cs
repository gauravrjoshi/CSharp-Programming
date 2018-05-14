using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            object name = "gaurav";
            char[] values = { 'g', 'a', 'u', 'r', 'a', 'v' };
            object myName = new string(values);
            Console.WriteLine("== operator result is {0}", name == myName);
            Console.WriteLine("Equals method result is {0}", myName.Equals(name));
            Console.ReadKey();
        }
    }
}
