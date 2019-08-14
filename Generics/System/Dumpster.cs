using Generics.Models;
using Generics.System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class MultiSlot
    {
        public IList<Food> Foods { get; } = new List<Food>();
        public IList<Trash> Waste { get; } = new List<Trash>();
        public IList<Bottle> Bottles { get; } = new List<Bottle>();
        public IList<Soda> Liquids { get; } = new List<Soda>();

        public void ProcessAll()
        {
            Process<Food>(Foods, (food) => Composter.GrowKale(food));
            Process<Trash>(Waste, (trash) => SmartIncinerator.Burn(trash));
            Process<Soda>(Liquids, (soda) => Sponge.SoakUp(soda));
            Process<Bottle>(Bottles, (bottle) => Melter.MakeFridgetSpinner(bottle));
        }

        public void Process<T>(IList<T> items, Action<T> disposalMethod)
        {
            foreach(var item in items)
            {
                disposalMethod(item);
                Console.WriteLine(item);
            }
        }

    }
}
