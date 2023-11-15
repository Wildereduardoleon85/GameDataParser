namespace GameDataParser.FilesManagement;

public class Txt
{
  public void CreateOrWrite(string path, string content, bool append = true)
  {
    StreamWriter writer = new(path, append);

    writer.WriteLine(content);
    writer.Close();
  }
}