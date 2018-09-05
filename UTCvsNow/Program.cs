using System;
using System.Diagnostics;

namespace UTCvsNow
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 1000000; i++)
            {
                var time = DateTime.UtcNow;
            }
            stopWatch.Stop();
            var utcTotalMilliseconds = stopWatch.ElapsedMilliseconds;

            stopWatch.Reset();
            stopWatch.Start();
            for (int i = 0; i < 1000000; i++)
            {
                var time = DateTime.Now;
            }
            stopWatch.Stop();
            var nowTotalMilliseconds = stopWatch.ElapsedMilliseconds;

            Console.WriteLine($"UTC:{utcTotalMilliseconds}\tNow:{nowTotalMilliseconds}");
            // UTC:21  Now:42
        }
    }
}
