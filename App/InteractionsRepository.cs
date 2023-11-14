
using GameDataParser.DataFormat;
using GameDataParser.GameEntity;

namespace game_data_parser.App;

public class InteractionsRepository
{
  public void PrintInitialInstructions()
  {
    Console.WriteLine("Enter the name of the file you want to read:");
  }

  public void Close()
  {
    Console.WriteLine("Press any key to close.");
    Console.ReadKey();
  }

  public void PrintListOfGames(IEnumerable<Game> games)
  {
    DataFormatRepository formatter = new();
    Console.WriteLine("Loaded games are:");
    Console.WriteLine(formatter.GetFormattedGames(games));
    Close();
  }
}
