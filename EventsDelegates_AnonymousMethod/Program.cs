using System;

namespace EventsDelegates_AnonymousMethod
{
    class Program
    {
        delegate void Printer(string s);

        public static void Main()
        {

            // Instantiate the delegate type using an anonymous method.
            Printer p = delegate (string j)
            {
                System.Console.WriteLine(j);
            };

            // Results from the anonymous delegate call.
            p("The delegate using the anonymous method is called.");

            // The delegate instantiation using a named method "DoWork".
            p = new Printer(DoWork);

            // Results from the old style delegate call.
            p("The delegate using the named method is called.");



            string mid = ", middle part,";

            Func<string, string> anonymousDelegate = delegate (string param)
            {
                param = param + mid;
                param = param + " and this was added to the string.";
                return param;
            };

            Console.WriteLine(anonymousDelegate("Start of string"));


        }

        // The method associated with the named delegate. 
        static void DoWork(string k)
        {
            System.Console.WriteLine(k);
        }
    }
}
