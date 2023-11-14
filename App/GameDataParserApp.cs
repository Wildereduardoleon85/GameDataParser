using GameDataParser.Validations;

namespace game_data_parser.App;

public class GameDataParserApp
{
  public void Init()
  {
    InteractionsRepository interaction = new();
    ValidationsRepository validation = new();

    interaction.PrintInitialInstructions();

    bool isInputValid = false;

    // while (!isInputValid)
    // {
    //   string? input = Console.ReadLine();

    // }
  }
}