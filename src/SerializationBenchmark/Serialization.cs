using BenchmarkDotNet.Attributes;
using SerializationBenchmark.Models;
using System.Text;

namespace SerializationBenchmark;

[MemoryDiagnoser]
public class Serialization
{
    SampleModel _sampleModel=new();

    [Benchmark]
    public void SerializeNewtonsoftJson()
    {
        Newtonsoft.Json.JsonConvert.SerializeObject(_sampleModel);
    }

    [Benchmark]
    public void SerializeSystemTextJson()
    {
        System.Text.Json.JsonSerializer.Serialize(_sampleModel);
    }
    [Benchmark]
    public void SerializeSystemTextSerializeToUtf8Bytes()
    {
        System.Text.Json.JsonSerializer.SerializeToUtf8Bytes(_sampleModel);
    }
    [Benchmark]
    public void SerializeByteFromJsonSytemText()
    {
        Encoding.Unicode.GetBytes(System.Text.Json.JsonSerializer.Serialize(_sampleModel));
    }
    [Benchmark]
    public void SerializeByteFromJsonNewtonsoft()
    {
        Encoding.Unicode.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(_sampleModel));
    }
}
