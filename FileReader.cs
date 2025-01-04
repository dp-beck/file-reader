namespace file_reader;

public class FileReader
{
    public void SaveToFile(string filePath, string content)
    {
        File.WriteAllText(filePath, content);
    }
    
    public string ReadFilteredTextFilesInFolder(string folderPath, string filter)
    {
        string[] fileNames = Directory.GetFiles(folderPath);
        string filesContent = "";
        foreach (var file in fileNames)
        {
            if (file.EndsWith(".txt"))
            {
                var fileContent = ReadSingleFileFirstLine(file);
                if (fileContent.Contains(filter))
                    filesContent += fileContent + Environment.NewLine;
            }
                
        }
        return filesContent;
    }
    public string ReadSingleFileFirstLine(string filePath)
    {
        try
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader(filePath);
            string line = sr.ReadLine();
            sr.Close();
            return line;
        }
        catch(Exception e)
        {
            return "Exception: " + e.Message; 
        }
    }
}