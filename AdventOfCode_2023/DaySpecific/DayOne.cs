using System.Reflection.Metadata;

namespace DaySpecific.Day_One;

public static class DayOne
{
	public static int[] ExtractIntegerCalibrationValues(string[] stringValues)
	{
		int[] calValues = new int[stringValues.Length];
		
		for (int x = 0; x < stringValues.Length; x++)
		{
			Console.WriteLine($"String: {stringValues[x]}");
			List<(int index, char digitCharacter)> digitPositions = new ();
			for (int y = 0; y < stringValues[x].Length; y++)
			{
				if (Char.IsDigit(stringValues[x][y]))
				{
					digitPositions.Add((y, stringValues[x][y]));
				}
			}
			digitPositions.AddRange(FindStringifiedDigits(stringValues[x]));
			digitPositions.Sort((x, y) => x.index.CompareTo(y.index));

			char[] temp = { digitPositions.First().digitCharacter, digitPositions.Last().digitCharacter };
			calValues[x] = int.Parse(new String(temp.ToArray()));
		}

		return calValues;
	}

	private static List<(int, char)> FindStringifiedDigits(string line)
	{
		List<(int, char)> occurrences = new List<(int, char)>();
		Dictionary<string, char> stringNumbers = new Dictionary<string, char>()
		{
			{ "one", '1' },
			{ "two", '2' },
			{ "three", '3' },
			{ "four", '4' },
			{ "five", '5' },
			{ "six", '6' },
			{ "seven", '7' },
			{ "eight", '8' },
			{ "nine", '9' }
		};

		foreach (KeyValuePair<string, char> element in stringNumbers)
		{
			int index = 0;

			while (index <= line.Length)
			{
				index = line.ToLower().IndexOf(element.Key, index, StringComparison.Ordinal);
				
				if (index < 0)
				{
					break;
				}
				occurrences.Add((index, element.Value));
				index++;
			}
		}
		return occurrences;
	}
}