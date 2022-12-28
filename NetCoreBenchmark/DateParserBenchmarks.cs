using BenchmarkDotNet.Attributes;

namespace NetCoreBenchmark
{
    [MemoryDiagnoser] // We want to known memory allocating
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)] // Order Benchmarks
    [RankColumn] // Shows the RankColumn
    public class DateParserBenchmarks
    {
        private const string DateTime = "2021-06-30T14:33:06Z";
        private static readonly DateParser Parser = new DateParser();

        [Benchmark(Baseline = true)]
        public void GetYearFromDateTime()
        {
            Parser.GetYearFromDateTime(DateTime);
        }

        [Benchmark]
        public void GetYearFromSplit()
        {
            Parser.GetYearFromSplit(DateTime);
        }

        [Benchmark]
        public void GetYearFromSubstring()
        {
            Parser.GetYearFromSubstring(DateTime);
        }

        [Benchmark]
        public void GetYearFromSpan()
        {
            Parser.GetYearFromSpan(DateTime);
        }
    }
}