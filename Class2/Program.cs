using System;

namespace Class2
{
    class Program
    {
        int i = 20;

        static void Main(string[] args)
        { 
            int i = 1;
            int j = 2;
            int k = 3;
            bool condition = true;
            int[] arraysOfInts = new int[] { 1, 2, 3, 4, 5, 6 };



            Console.WriteLine("\n RELATIONAL OPERATORS");
            Console.WriteLine("a" == "b");
            Console.WriteLine("a" != "b");
            Console.WriteLine(3 > 5);
            Console.WriteLine(1 > 0);

            Console.WriteLine("\n VALUE TYPES");
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);

            SomeClass nx = new SomeClass();
            SomeClass first = new SomeClass();
            SomeClass second = new SomeClass();

            Console.WriteLine("\n REFERENCE TYPES");
            Console.WriteLine(first.x);
            Console.WriteLine(second.y);


            Console.WriteLine("\n SWITCH STATEMENT");
            switch (i)
            {
                case 1:
                    Console.WriteLine("i=1");
                    break;
                case 2:
                    Console.WriteLine("i=2");
                    break;
                case 3:
                    Console.WriteLine("i=3");
                    break;
                // if none of the conditions are met the 'default' (optional) statement is executed
                default:
                    Console.WriteLine("i is not 1,2, or 3");
                    break;

            }


            Console.WriteLine("\n FOR LOOP");
            for (int l = 0; l < 20; l++)
            {
                for (int m = i; m < i + 10; m++)
                {
                    Console.Write("{0} ", m.ToString("D2"));
                }
                Console.WriteLine("End of m loop");

            }
            Console.WriteLine("End of l loop");
            // the loop condition is tested prior to every loop
            // the loop executes only while the condition is true 
            Console.WriteLine("\n WHILE LOOP");
            while (condition)
            {
                Console.WriteLine("While Loop!");
                condition = ReturnFalse();
            }


            Console.WriteLine("\n DO WHILE LOOP");
            // the loop condition is tested after every loop
            // the loop executes only while the condition is true 
            do
            {
                Console.WriteLine("Do While Loop!");
                condition = ReturnFalse();
            }
            while (condition);

            Console.WriteLine("\n FOREACH LOOP");

            foreach(int x in arraysOfInts)
            {
                Console.WriteLine("x is {0}", x);
            }

            Console.WriteLine("\n GOTO");
            goto displayInfo;

            Console.WriteLine("jump failed...");//skipped line

        displayInfo:

            { Console.WriteLine("jumped into label..."); }
        }


        public static bool ReturnFalse()
        {
            return false;
        }
    }

   

    class SomeClass
    {
        public int x;
        public int y;

        public SomeClass()
        {
            x = 10;
            y = 10;
        }



    }
}
