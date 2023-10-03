using System.Text.Json;
using System.Text.Json.Serialization;

public abstract class TestBase
{
}

[JsonConverter(typeof(Test1JsonConverter))]
public class Test1 : TestBase
{
    public string P1 { get; set; } = "Prop 1";
}

public class Test1JsonConverter : JsonConverter<Test1>
{
    public override Test1? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, Test1 value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteString("Test1JsonConverter", "This is the correct converter. NET 6/7 uses this.");

        writer.WriteEndObject();
    }
}