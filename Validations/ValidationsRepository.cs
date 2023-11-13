namespace GameDataParser.Validations;

public class ValidationsRepository
{
  public bool FileExists(string? fileName)
  {
    if (fileName is not null)
    {
      bool isValid = true;
      if (File.Exists(fileName.Trim()))
      {
        return isValid;
      }
      isValid = false;
      return isValid;
    }

    return false;
  }

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

    return new ValidationResult() { IsValid = true, Value = input.Trim() };
  }

  public class ValidationResult
  {
    public bool IsValid { get; set; }
    public string? ErrorMessage { get; set; }
    public string? Value { get; set; }
  }
}