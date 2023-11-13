using game_data_parser.Validations;

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

    }
  }
}