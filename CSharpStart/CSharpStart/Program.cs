using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci ededi daaxil edin: ");
            string a = Console.ReadLine();
            Console.Write("ikinci ededi daaxil edin: ");
            string b = Console.ReadLine();
            int c = Convert.ToInt32(a) * Convert.ToInt32(b);
            Console.WriteLine("Cavab : " + c);
            Console.ReadLine();
            


        }
    }
}
