using BenchmarkDotNet.Running;
using Day1.Benchmarks;
using System;
using System.IO;
using System.Linq;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Day2PartBBenchmarks>();
        }
    }
}
