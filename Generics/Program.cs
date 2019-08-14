using Generics.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Program
    {
        private static MultiSlot _dumpster;
        public static void Main(string[] args)
        {
            _dumpster = new MultiSlot();
            _dumpster.Bottles.Add(new Bottle());
            _dumpster.Bottles.Add(new Bottle());
            _dumpster.Foods.Add(new Food());
            _dumpster.Foods.Add(new Food());
            _dumpster.Waste.Add(new Trash());
            _dumpster.Liquids.Add(new Soda());

            _dumpster.ProcessAll();
        }

    }
}
