using static AdventOfCode_2023.Filesystem.FilesystemIO;
using DaySpecific.Day_One;

namespace AdventOfCode_2023;
class Program
{
	static void Main(string[] args)
	{
		string[] calibrationFile = ReadCalibrationDocument();
		
		// Day One
		string[] convertedValues = DayOne.ConvertStringifiedNumbers(calibrationFile);
		int[] dayOneValues = DayOne.ExtractIntegerCalibrationValues(convertedValues);
		Console.WriteLine($"Day One Calibration Values: {dayOneValues.Sum()}");
		
	}
}