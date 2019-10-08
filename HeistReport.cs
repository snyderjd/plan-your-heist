using System;
using System.Collections.Generic;

namespace heist
{
    class HeistReport
    {
        public HeistReport()
        {
            SuccessCount = 0;
            FailureCount = 0;
        }
        public int SuccessCount { get; set; }
        public int FailureCount { get; set; }

        public void Print()
        {
            Console.WriteLine("==================");
            Console.WriteLine("Simulation Results:");
            Console.WriteLine("------------------------");
            Console.WriteLine($"Successes: {this.SuccessCount}");
            Console.WriteLine($"Failures: {this.FailureCount}");
            Console.WriteLine("==================");
        }
    }
}