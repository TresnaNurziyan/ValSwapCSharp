using System;

namespace SoalPertama
{
    class Program
    {
        void swapByValue(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        void swapByReference(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void Main(String[] args)
        {
            int a = 1;
            int b = 5;

            Program p = new Program();

            Console.WriteLine("nilai x : " + a);
            Console.WriteLine("nilai y : " + b);

            p.swapByValue(a, b);

            Console.WriteLine("nilai x by val setelah swap : " + a);
            Console.WriteLine("nilai y by val setelah swap : " + b);

            p.swapByReference(ref a, ref b);

            Console.WriteLine("nilai x by ref setelah swap : " + a);
            Console.WriteLine("nilai y by ref setelah swap : " + b);
            Console.ReadKey();
        }
    }
}
