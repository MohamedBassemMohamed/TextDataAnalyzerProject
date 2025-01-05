using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDataAnalyzerProject
{
    public class CsvFileAnalyzer : FileAnalyzer, IFileAnalysis
    {
        public void AnalyzeFile(FileInfo fileInfo)
        {
            string[] fileString = File.ReadAllLines(fileInfo.FullName);
            var rowelements = fileString[0].Split(',');
            AnalysisResults results = new AnalysisResults();
            results.FieldCount = rowelements.Length;
            SetReults(results);
        }
    }
}
