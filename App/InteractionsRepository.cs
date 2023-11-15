
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

  public void PrintErrorMessage(string errorMessage)
  {
    Console.WriteLine(errorMessage);
  }

  public void PrintJsonException(string fileName, string jsonBody)
  {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Clear();
    Console.WriteLine($"JSON in the {fileName} was not in a valid format. JSON body:");
    Console.WriteLine(jsonBody);
    Console.ResetColor();
    PrintExceptionApologize();
    Close();
  }

  public void PrintExceptionApologize()
  {
    Console.WriteLine(
      "Sorry! The application has experienced an unexpected error and will " +
      "have to be closed."
    );
  }
}
