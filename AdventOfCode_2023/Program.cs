using static AdventOfCode_2023.Filesystem.FilesystemIO;
using DaySpecific.Day_One;

namespace AdventOfCode_2023;
class Program
{
	static void Main(string[] args)
	{
		// Day One
		string[] calibrationFile = ReadCalibrationDocument();
		// string[] calibrationFile = new []
		// {
		// 	"two1nine",
  //           "eightwothree",
  //           "abcone2threexyz",
  //           "xtwone3four",
  //           "4nineeightseven2",
  //           "zoneight234",
  //           "7pqrstsixteen"
		// };
		
		int[] dayOneValues = DayOne.ExtractIntegerCalibrationValues(calibrationFile);
		Console.WriteLine($"Day One Calibration Values: {dayOneValues.Sum()}");

	}
}