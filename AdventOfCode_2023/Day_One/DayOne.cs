using System.Collections.Immutable;
using System.Net.Mime;
using System.Reflection;

namespace AdventOfCode_2023.Day_One;

public static class DayOne
{
	public static void RunDayOne()
	{
		string[] inputData = ReadCalibrationDocument();
		int[] calibrationValues = ExtractCalibrationValues(inputData);

		Console.Write($"Calibration Sum Value: {calibrationValues.Sum()}");
	}

	private static string[] ReadCalibrationDocument()
	{
		string folder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!;
		string filePath = Path.Combine(folder, @"Day_One\input\CalibrationDoc");
		
		return File.ReadAllLines(filePath);
	}

	private static int[] ExtractCalibrationValues(string[] fileContents)
	{
		int[] calValues = new int[fileContents.Length];
		char[] temp;
		
		for (int x = 0; x < fileContents.Length; x++)
		{
			IList<char> intChars = fileContents[x].Where(Char.IsDigit).ToList();
			temp = new[] { intChars[0], intChars[^1] };	
			calValues[x] = int.Parse(new String(temp.ToArray()));
		}

		return calValues;
	}
}