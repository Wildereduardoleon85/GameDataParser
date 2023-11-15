namespace GameDataParser.Exceptions
{
  public class Ex
  {
    public string GetDetails(Exception ex)
    {
      string formattedTime = DateTime.Now.ToString(
        "dd/M/yyyy h:mm:ss tt",
        System.Globalization.CultureInfo.InvariantCulture
      );

      return $"[{formattedTime}]" + Environment.NewLine +
        $"Exception message: {ex.Message}" + Environment.NewLine +
        $"Stack trace: {ex.StackTrace}";
    }
  }
}