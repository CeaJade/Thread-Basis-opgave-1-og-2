using System;
using System.Threading;

namespace ThreadBasis1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(Write);
                Thread t2 = new Thread(Write);
                t1.Start();
                Thread.Sleep(1000);
                t2.Start();
            }
        }

        static void Write()
        {
            Console.WriteLine("C#-trådning er nemt!");
        }
    }
}
