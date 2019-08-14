using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Generics.Models
{
    public class Food
    {
        private static int counter = 1;
        public Food()
        {
            Console.WriteLine($"{counter} food is thrown");
            Interlocked.Increment(ref counter);
        }
    }
}
