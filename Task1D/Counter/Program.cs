using System;
using System.Diagnostics.Metrics;

namespace CounterTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock myclock = new Clock();
            for (int i = 0; i < 86450; i++)
            {
                myclock.Tick();
                Console.WriteLine(myclock.Time());
            }
        }
    }
}