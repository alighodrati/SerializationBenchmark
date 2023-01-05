namespace SerializationBenchmark.Models;

internal class SampleChildModel
{
    public SampleChildModel()
    {
        MyProperty = long.MaxValue;
        MyProperty1 = "sample String For Generating this class";
        MyProperty2 = DateTime.Now;
        MyProperty3 = int.MaxValue;
        MyProperty4 = float.MaxValue;
    }

    public long MyProperty { get; set; }
    public string MyProperty1 { get; set; }
    public DateTime MyProperty2 { get; set; }
    public int MyProperty3 { get; set; }
    public float MyProperty4 { get; set; }

}

