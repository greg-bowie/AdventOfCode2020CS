using BenchmarkDotNet.Running;
using Day1.Benchmarks;
using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Day1PartABenchmarks>();
        }
    }
}
