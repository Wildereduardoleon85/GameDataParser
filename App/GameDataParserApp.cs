using GameDataParser.Exceptions;
using GameDataParser.FilesManagement;
using GameDataParser.GameEntity;
using GameDataParser.Validations;
using static GameDataParser.FilesManagement.Json;

namespace game_data_parser.App;

public class GameDataParserApp
{
  public void Init()
  {
    InteractionsRepository interaction = new();
    ValidationsRepository validation = new();
    Json json = new();
    Ex exception = new();
    Txt text = new();

    bool shouldKeepAsking = true;

    while (shouldKeepAsking)
    {
      interaction.PrintInitialInstructions();
      string? input = Console.ReadLine();
      var validationResult = validation.ValidateInput(input);

      if (!validationResult.IsValid)
      {
        interaction.PrintErrorMessage(validationResult.ErrorMessage);
      }
      else
      {
        TryDeserializeResult<Game[]> jsonParseResult =
          json.TryDeserialize<Game[]>(validationResult.Value);

        if (jsonParseResult.Success)
        {
          interaction.PrintListOfGames(jsonParseResult.DeserializedData!);
        }
        else
        {
          string exceptionDetails = exception.GetDetails(jsonParseResult.Ex!);
          text.CreateOrWrite("log.txt", exceptionDetails + Environment.NewLine);

          interaction.PrintJsonException(
            validationResult.Value,
            jsonParseResult.JsonBody
          );
        }
        shouldKeepAsking = false;
      }
    }
  }
}