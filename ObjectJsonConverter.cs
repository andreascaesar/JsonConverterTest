using System.Text.Json;
using System.Text.Json.Serialization;

public class ObjectJsonConverter : JsonConverter<object>
{
    public override object? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteString("ObjectJsonConverter", "This is incorrect converter. NET 8 RC1 uses this. Switch to .NET 6 or 7 to see that the correct converter is used.");

        writer.WriteEndObject();
    }
}