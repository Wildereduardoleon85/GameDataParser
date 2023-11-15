namespace GameDataParser.Validations;

public class ValidationsRepository
{
  public ValidationResult ValidateInput(string? input)
  {
    if (input is null)
    {
      return new ValidationResult()
      {
        IsValid = false,
        ErrorMessage = "File name cannot be null"
      };
    }

    if (input.Trim() == "")
    {
      return new ValidationResult()
      {
        IsValid = false,
        ErrorMessage = "File name cannot be empty"
      };
    }

    if (!FileExists(input))
    {
      return new ValidationResult()
      {
        IsValid = false,
        ErrorMessage = "File not found"
      };
    }

    return new ValidationResult() { IsValid = true, Value = input.Trim() };
  }

  public class ValidationResult
  {
    public bool IsValid { get; set; }
    public string ErrorMessage { get; set; } = "";
    public string Value { get; set; } = "";
  }

  protected bool FileExists(string? fileName)
  {
    bool isValid = false;

    if (fileName is not null && File.Exists(fileName.Trim()))
    {
      isValid = true;
    }

    return isValid;
  }
}