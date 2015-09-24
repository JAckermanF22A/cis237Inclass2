using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237InClass2
{
    class Hanoi
    {
        public void moveDisc(int n, char source, char auxPerc, char destination)
        {
            if (n == 1)
            {
                Console.WriteLine("Move Disk from tower {0} to tower {1}", source, destination);
            }
            else
            {
                moveDisc(n - 1, source, destination, auxPerc);
                moveDisc(1, source, auxPerc, destination);
                moveDisc(n - 1, auxPerc, source, destination);
            }
        }

    }
}
