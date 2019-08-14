using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Generics.Models
{
    public class Trash
    {
        private static int counter = 1;
        public Trash()
        {
            Console.WriteLine($"{counter} trash is thrown");
            Interlocked.Increment(ref counter);
        }
    }
}
