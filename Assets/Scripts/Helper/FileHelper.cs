

using System.IO;

public class FileHelper  {
	public static void SaveStringToFile(string path,string content)
	{
		StreamWriter writer = new StreamWriter (path);
		writer.Write (content);
		writer.Close ();

	}
}
