namespace DaySpecific.Day_One;

public static class DayOne
{
	/// <summary>
	/// Extracts all digit <c>Char</c> from an array of strings. Created for AoC day one.
	/// </summary>
	/// <param name="fileContents"><c>string[]</c> representation of the calibration file</param>
	/// <returns>An <c>int[]</c> that are the first and last digit characters in the given string array index</returns>
	public static int[] ExtractIntegerCalibrationValues(string[] fileContents)
	{
		int[] calValues = new int[fileContents.Length];
		
		for (int x = 0; x < fileContents.Length; x++)
		{
			IList<char> intChars = fileContents[x].Where(Char.IsDigit).ToList();
			char[] temp = { intChars[0], intChars[^1] };	
			calValues[x] = int.Parse(new String(temp.ToArray()));
		}

		return calValues;
	}
}