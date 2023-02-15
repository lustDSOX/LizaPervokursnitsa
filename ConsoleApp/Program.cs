using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REG_MARK_LIB;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new Class();
            string text = "а999аа999";
            string answer = calc.GetNextMarkAfterInRange(text, "а400аа999","а400аа999");
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
