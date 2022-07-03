using System;

namespace projeto_banco
{
    class Program
    {
        public static int  add (int a, int b) {
            //a = 51;
            if (a > 50) throw new Exception ("teste");
            return a+b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine (add (51,25));
            //throw new Exception ();
        }
    }
}



