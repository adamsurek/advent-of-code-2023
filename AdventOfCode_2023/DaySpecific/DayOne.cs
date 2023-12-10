namespace DaySpecific.Day_One;

public static class DayOne
{
	/// <summary>
	/// Extracts all digit <c>Char</c> from an array of strings. Created for AoC day one.
	/// </summary>
	/// <param name="stringValues"><c>string[]</c> to extract values from</param>
	/// <returns>An <c>int[]</c> that are the first and last digit characters in the given string array index</returns>
	public static int[] ExtractIntegerCalibrationValues(string[] stringValues)
	{
		int[] calValues = new int[stringValues.Length];
		
		for (int x = 0; x < stringValues.Length; x++)
		{
			IList<char> intChars = stringValues[x].Where(Char.IsDigit).ToList();
			char[] temp = { intChars[0], intChars[^1] };	
			calValues[x] = int.Parse(new String(temp.ToArray()));
		}

		return calValues;
	}
	
	public static string[] ConvertStringifiedNumbers(string[] fileContents)
	{
		string[] updatedContents = new string[fileContents.Length];
		Dictionary<string, string> stringNumberMap = new Dictionary<string, string>()
		{
			{ "zero", "0" },
			{ "one", "1" },
			{ "two", "2" },
			{ "three", "3" },
			{ "four", "4" },
			{ "five", "5" },
			{ "six", "6" },
			{ "seven", "7" },
			{ "eight", "8" },
			{ "nine", "9" }
		};

		for (int x = 0; x < fileContents.Length; x++)
		{
			foreach (KeyValuePair<string, string> element in stringNumberMap)
			{
				fileContents[x] = fileContents[x].Replace(element.Key, element.Value);
			}
			updatedContents[x] = fileContents[x];
		}

		return updatedContents;
	}
}