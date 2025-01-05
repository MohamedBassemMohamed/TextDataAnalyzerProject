
using TextDataAnalyzerProject;

Console.WriteLine("Welcome to Text Data Analyzer!");
Console.WriteLine("Enter the folder path to analyze:");

string inputFolder = Console.ReadLine();

DirectoryInfo directoryInfo = new DirectoryInfo(inputFolder);

if (directoryInfo.Exists == false)
{
    Console.WriteLine("folder doesnt exist");
    return;
}

var filenames = directoryInfo.GetFiles();
IFileAnalysis fileAnalysis = null;
foreach (var file in filenames)
{
    if (file.IsTextFile())
    {
        fileAnalysis = new TxtFileAnalyzer();
        fileAnalysis.AnalyzeFile(file);

        var results = ((FileAnalyzer)fileAnalysis).GetReults();

        Console.WriteLine($"File Name:{file.Name}");
        Console.WriteLine($"Word count:{results.WordCount}");
        Console.WriteLine($"Character count:{results.CharacterCount}");
        Console.WriteLine($"line count:{results.LineCount}");
    }
    else if (file.IsCsvFile())
    {
        fileAnalysis = new CsvFileAnalyzer();
        fileAnalysis.AnalyzeFile(file);

        var results = ((FileAnalyzer)fileAnalysis).GetReults();

        Console.WriteLine($"File Name:{file.Name}");
        Console.WriteLine($"Field count:{results.FieldCount}");
        
    }

}
