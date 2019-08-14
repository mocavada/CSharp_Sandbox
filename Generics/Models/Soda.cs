using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Generics.Models
{
    public class Soda
    {
        private static int counter = 1;
        public Soda()
        {
            Console.WriteLine($"{counter} soda is thrown");
            Interlocked.Increment(ref counter);
        }
    }
}
