using System;
using BenchmarkDotNet.Running;

namespace NetCoreBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            //Run the Benchmarks
            BenchmarkRunner.Run<DateParserBenchmarks>();
        }
    }
}
