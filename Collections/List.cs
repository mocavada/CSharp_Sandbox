using System;
using System.Collections.Generic;

namespace Collections
{
    class List
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> myList = new List<int>();

            myList.Add(1);
            myList.Add(5);
           

            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine(myList.ToString());
        }
    }
}
