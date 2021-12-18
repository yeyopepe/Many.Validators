﻿using BenchmarkDotNet.Running;
using System;

namespace Many.Validators.Benchmark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($">>>>>>>>>>>>>>> {DateTime.Now}");

            var summary = BenchmarkRunner.Run<GreaterThanZeroValidator>();

            Console.WriteLine($">>>>>>>>>>>>>>> {DateTime.Now}");
        }
    }
}

    
