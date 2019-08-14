using Generics.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.System
{
    public class Incinerator
    {
        public static void Burn(Object trash)
        {
            // TODO: Implement
        }
    }

    public class SmartIncinerator
    {
      
        public static void Burn(Trash trash)
        {
         
            Console.WriteLine("trash is burn");
        }
    }

    // * TYPE PARAMETERS
    public class TypeParameters_SmartIncinerator
    {
        public Action DestroyMethod { get; set; }
        public void Burn<T>(T destroyMe)
        {
            var typeOfT = typeof(T).ToString();

            DestroyMethod();
           
            Console.WriteLine($"T is {typeOfT}");
            
        }
    }
}
