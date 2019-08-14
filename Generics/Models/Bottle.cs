using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Generics.Models
{
    public class Bottle
    {
        private static int counter = 1;
        public Bottle()
        {
            Console.WriteLine($"{counter} bottle is thrown ");
            Interlocked.Increment(ref counter);

        }
    }
}
