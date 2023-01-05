using BenchmarkDotNet.Attributes;
using SerializationBenchmark.Models;
using System.Text;

namespace SerializationBenchmark;

[MemoryDiagnoser]
public class Serialization
{
    SampleModel _sampleModel = new();
    string _serilizeStr = System.Text.Json.JsonSerializer.Serialize(new SampleModel());

    [Benchmark]
    public void Json_Serialize_Newtonsoft()
    {
        Newtonsoft.Json.JsonConvert.SerializeObject(_sampleModel);
    }

    [Benchmark]
    public void Json_Serialize_SystemTextJson()
    {
        System.Text.Json.JsonSerializer.Serialize(_sampleModel);
    }
    [Benchmark]
    public void Byte_Serialize_SystemTextUtf8Bytes()
    {
        System.Text.Json.JsonSerializer.SerializeToUtf8Bytes(_sampleModel);
    }
    [Benchmark]
    public void Byte_From_String()
    {
        Encoding.Unicode.GetBytes(_serilizeStr);
    }
}
