using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello LINQ!");

            string[] names = {
                "Joe","James","Bill","Sally", "Jill", "Jane","Leo","Larry", "Lacy"
            };

            Console.WriteLine(names[1]);

            //* Query Syntax **//
            IEnumerable<string> query = from c in names where c.StartsWith("J") select c;

            Console.WriteLine("Query Syntax Results:");
            foreach (string str in query)
            {
                Console.WriteLine(str);
            }


            //** Method Syntax **//
            IEnumerable<string> method = names.Where(n => n.StartsWith("J"));

            Console.WriteLine("\nMethod Syntax Results:");
            foreach (string str in method)
            {
                Console.WriteLine(str);
            }

            //1 Named Method
            IEnumerable<string> name = names.Where(StartsWithL);
            Console.WriteLine("\nNamed Method Results:");
            foreach (string str in name)
            {
                Console.WriteLine(str);
            }


            //2 Anonymous Method
            IEnumerable<string> nameAnonymous = names.Where(delegate (string s)
            {
                return s.StartsWith("L");
            });
            Console.WriteLine("\nAnonymous Method Results:");
            foreach (string str in nameAnonymous)
            {
                Console.WriteLine(str);
            }

            //3 Lambda Expression
            IEnumerable<string> nameLambda = names.Where(s => s.StartsWith("L"));
            Console.WriteLine("\nLambda Method Results:");
            foreach (string str in nameLambda)
            {
                Console.WriteLine(str);
            }


            //** Interface **//
            MyList list = new MyList();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            IEnumerable<int> result = list.Where(r => r > 4);

            Console.WriteLine("\nInterface:");
            foreach (int item in result)
            {
                Console.WriteLine(item);
                Console.ReadLine();

            }
                


        }

        public static bool StartsWithL(string name)
        {
            return name.StartsWith("L");
        }

    }

    //** Interface **//

    public class MyList : IEnumerable<int>
    {
        List<int> _list = new List<int>();

        public void Add(int item)
        {
            _list.Add(item);
        }

        public IEnumerator<int> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
