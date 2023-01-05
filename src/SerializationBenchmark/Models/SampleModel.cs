namespace SerializationBenchmark.Models;

internal class SampleModel
{
    public SampleModel()
    {
        MyProperty = long.MaxValue;
        MyProperty1 = "sample String For Generating this class";
        MyProperty2 = DateTime.Now;
        MyProperty3 = int.MaxValue;
        MyProperty4 = float.MaxValue;
        Items = Enumerable.Range(0, 100).Select(s => new SampleChildModel()).ToList();
    }
    public List<SampleChildModel> Items { get; set; }
    public long MyProperty { get; set; }
    public string MyProperty1 { get; set; }
    public DateTime MyProperty2 { get; set; }
    public int MyProperty3 { get; set; }
    public float MyProperty4 { get; set; }
}

