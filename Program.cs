using System.Text.Json;
using game_data_parser.App;
using game_data_parser.DataFormat;
using game_data_parser.Entities;
using game_data_parser.Validations;
using Microsoft.VisualBasic;

// Console.WriteLine("Enter the name of the file you want to read:");
// string? fileName = Console.ReadLine();

// if (fileName is not null && new ValidationsRepository().IsFileNameValid(fileName))
// {
//   string content = File.ReadAllText(fileName.Trim());
//   var games = JsonSerializer.Deserialize<List<Game>>(content);
//   foreach (var item in games)
//   {
//     Console.WriteLine(item.Title);
//   }
//   Console.WriteLine("press any key to exit");
//   Console.ReadKey();
// }
// else
// {
//   Console.WriteLine("The file does not exists");
//   Console.WriteLine("press any key to exit");
//   Console.ReadKey();
// }

List<Game> games = new()
{
  new Game()
  {
    Title = "Pac man",
    Rating = 3.5,
    ReleaseYear = 1993,
  },
  new Game()
  {
    Title = "Tetris",
    Rating = 4.8,
    ReleaseYear = 1983,
  },
  new Game()
  {
    Title = "Pong",
    Rating = 3,
    ReleaseYear = 1981,
  }
};

InteractionsRepository interaction = new();

interaction.PrintListOfGames(games);



