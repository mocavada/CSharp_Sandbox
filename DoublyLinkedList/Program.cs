using System;

namespace DoublyLinkedList
{
    class Program
    {


        static void Main(string[] args)
        {
            Customer Joe = new Customer()
            {
                FirstName = "Joe",
                LastName = "Smith",
                DoB = new DateTime(1981, 1, 1),
                Previous = null,
                Next = new Customer()
            };

            Customer Sally = new Customer()
            {
                FirstName = "Sally",
                LastName = "Jones",
                DoB = new DateTime(1998, 5, 23),
                Previous = Joe,
                Next = null
            };
            Customer Jane = new Customer()
            {
                FirstName = "Jane",
                LastName = "Walter",
                DoB = new DateTime(1990, 2, 14),
                Previous = Sally,
                Next = Joe
            };

            Sally.Next = Jane;

            Customer head = Joe;

            while (head != null)
            {
                Console.WriteLine($"{head.FirstName} {head.LastName} {head.Age()}");
                head = head.Next;
            }

            Customer tail = Jane;
            while (tail != null)
            {
                Console.WriteLine($"{tail.FirstName} {tail.LastName} {tail.Age()}");
                tail = tail.Previous;
            }

        }
    }

}
