using BenchmarkDotNet.Attributes;
using SerializationBenchmark.Models;
using System.Text;

namespace SerializationBenchmark;

[MemoryDiagnoser]
public class Desrialization
{
    SampleModel _sampleModel = new();
    string _serilizeStr = System.Text.Json.JsonSerializer.Serialize(new SampleModel());
    byte[] _serializeByte = System.Text.Json.JsonSerializer.SerializeToUtf8Bytes(new SampleModel());

    [Benchmark]
    public void Json_Deserialize_Newtonsoft()
    {
        Newtonsoft.Json.JsonConvert.DeserializeObject<SampleModel>(_serilizeStr);
    }

    [Benchmark]
    public void Json_Deserialize_SystemTextJson()
    {
        System.Text.Json.JsonSerializer.Deserialize<SampleModel>(_serilizeStr);
    }
    [Benchmark]
    public void Byte_Deserialize_SystemTextUtf8Bytes()
    {
        System.Text.Json.JsonSerializer.Deserialize<SampleModel>(_serializeByte);
    }
    [Benchmark]
    public void Byte_From_String()
    {
        Encoding.Unicode.GetString(_serializeByte);
    }
}
