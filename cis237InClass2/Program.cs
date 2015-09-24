using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237InClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial factorial = new Factorial();

            Console.WriteLine("The answer to 5! is: " + factorial.Calculate(5));

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("");

            Hanoi hanoi = new Hanoi();

            hanoi.moveDisc(30, 'A', 'B', 'C');

        }
    }
}
