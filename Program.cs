using file_reader;

var fileReader = new FileReader();

string? folderPath = "";
while (string.IsNullOrEmpty(folderPath))
{
    Console.WriteLine("Enter the folder path for the folder files you want to read:");
    folderPath = Console.ReadLine();    
}

string? fileFilter = "";
while (string.IsNullOrEmpty(fileFilter))
{
    Console.WriteLine("Enter the string to filter the files by:");
    fileFilter = Console.ReadLine();    
}


var files = fileReader.ReadFilteredTextFilesInFolder(folderPath, fileFilter);

fileReader.SaveToFile(folderPath + "result.txt", files);

Console.WriteLine("done, check file result.txt in folder");
