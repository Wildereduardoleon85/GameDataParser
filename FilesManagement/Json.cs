using System.Text.Json;
namespace GameDataParser.FilesManagement;

public class Json
{
  public TryDeserializeResult<T> TryDeserialize<T>(string file)
  {
    string content = File.ReadAllText(file);
    try
    {
      var deserializedData = JsonSerializer.Deserialize<T>(content);
      if (deserializedData is null)
      {
        return new TryDeserializeResult<T>()
        {
          Success = false
        };
      }

      return new TryDeserializeResult<T>()
      {
        DeserializedData = deserializedData,
        Success = true
      };
    }
    catch (JsonException ex)
    {
      return new TryDeserializeResult<T>()
      {
        Success = false,
        Ex = ex,
        JsonBody = content
      };
    }
  }

  public class TryDeserializeResult<T>
  {
    public T? DeserializedData { get; set; }
    public bool Success { get; set; }
    public Exception? Ex { get; set; }
    public string JsonBody { get; set; } = "";
  }
}