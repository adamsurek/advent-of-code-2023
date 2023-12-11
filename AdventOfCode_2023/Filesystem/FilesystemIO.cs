using System.Reflection;

namespace AdventOfCode_2023.Filesystem;

public static class FilesystemIO
{
	/// <summary>
	/// Reads all lines of the calibration document found in input folder
	/// </summary>
	/// <returns>Returns <c>string[]</c> containing all lines</returns>
	public static string[] ReadFlatFile(string fileName)
	{
		string folder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!;
		string filePath = Path.Combine(folder, $@"input\{fileName}");
		
		return File.ReadAllLines(filePath);
	}
}