using BenchmarkDotNet.Running;
using SerializationBenchmark;

BenchmarkRunner.Run<Serialization>();
BenchmarkRunner.Run<Desrialization>();