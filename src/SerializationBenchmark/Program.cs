using BenchmarkDotNet.Running;
using SerializationBenchmark;

var summary = BenchmarkRunner.Run<Serialization>();