namespace DaySpecific.Day_One;

public static class DayTwo
{
	public static int DayTwoAnswer(string[] cubeGameResults)
	{
		List<Game> games = SetupGameClasses(cubeGameResults);

		/*
		// Part One
		List<int> possibleGameIds = new List<int>();

		foreach (Game game in games)
		{
			if (game.Rounds.All(x => x.RedCubes <= 12 && x.GreenCubes <= 13 && x.BlueCubes <= 14))
			{
				possibleGameIds.Add(game.Id);
			}
		}

		return possibleGameIds.Sum();
		*/
		
		// Part Two
		List<(int minRed, int minGreen, int minBlue)> gameMins = new List<(int minRed, int minGreen, int minBlue)>();
		int powerSums = 0;
		foreach (Game game in games)
		{
			gameMins.Add((
				minRed: game.Rounds.Max(x => x.RedCubes),
				minGreen: game.Rounds.Max(x => x.GreenCubes),
				minBlue: game.Rounds.Max(x => x.BlueCubes)));
		}

		foreach ((int minRed, int minGreen, int minBlue) minSets in gameMins)
		{
			powerSums += minSets.minRed * minSets.minGreen * minSets.minBlue;
		}
		
		return powerSums;
	}

	private static List<Game> SetupGameClasses(string[] cubeGameResults)
	{
		List<Game> games = new List<Game>();
		
		foreach (string result in cubeGameResults)
		{
			Game game = new Game(int.Parse(result.Split(":")[0].Split(" ")[1]));

			string[] rounds = result.Split(":")[1].Trim().Split(";");
			for (int r = 0; r < rounds.Length; r++)
			{
				foreach (string cubeCount in rounds[r].Trim().Split(","))
				{
					string[] splitCount = cubeCount.Trim().Split(" ");
					int red = 0;
					int green = 0;
					int blue = 0;
					switch (splitCount[1])
					{
						case "red":
							red = int.Parse(splitCount[0]);
							break;
						
						case "green":
							green = int.Parse(splitCount[0]);
							break;
						
						case "blue":
							blue = int.Parse(splitCount[0]);
							break;
					}

					Round round = new Round(r, red, green, blue);
					game.Rounds.Add(round);
				}
			}
			games.Add(game);
		}

		return games;
	}
}

public class Game
{
	public int Id;
	public bool IsPossible;
	public List<Round> Rounds = new List<Round>();

	public Game(int id)
	{
		Id = id;
	}
}

public class Round
{
	public int Id;
	public int RedCubes;
	public int GreenCubes;
	public int BlueCubes;

	public Round(int id, int red, int green, int blue)
	{
		Id = id;
		RedCubes = red;
		GreenCubes = green;
		BlueCubes = blue;
	}
}
