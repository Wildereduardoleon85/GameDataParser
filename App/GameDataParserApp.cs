using GameDataParser.Validations;

namespace game_data_parser.App;

public class GameDataParserApp
{
  public void Init()
  {
    InteractionsRepository interaction = new();
    ValidationsRepository validation = new();

    interaction.PrintInitialInstructions();

    string? input = Console.ReadLine();

    if (validation.FileExists(input))
    {
      Console.WriteLine("the file exists");
    }
  }
}