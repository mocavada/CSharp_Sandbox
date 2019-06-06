using System;
using System.Collections.Generic;
using System.Text;
namespace DoublyLinkedList

{
    public class Customer
    {
        public string FirstName;
        public string LastName;
        public DateTime DoB;
        public Customer Next;
        public Customer Previous;

        public int Age()
        {
            return (DateTime.Now - DoB).Days / 365;
        }
    }
}
