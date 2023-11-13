using System.Text;
using game_data_parser.Entities;

namespace game_data_parser.DataFormat;

public class DataFormatRepository
{
  /// <summary>
  /// Transform a list of Games into a string shape.
  /// </summary>
  public string GetFormattedGames(IEnumerable<Game> games)
  {
    List<Game> gameList = games.ToList();
    StringBuilder builder = new();

    for (var i = 0; i < gameList.Count; i++)
    {
      string joinedGameData =
        $"{gameList[i].Title}, released in {gameList[i].ReleaseYear}, " +
        $"rating: {gameList[i].Rating}";

      if (i == gameList.Count - 1)
      {
        builder.Append(joinedGameData);
      }
      else
      {
        builder.Append(joinedGameData + Environment.NewLine);
      }
    }

    return builder.ToString();
  }
}
