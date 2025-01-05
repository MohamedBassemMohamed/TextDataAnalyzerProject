using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDataAnalyzerProject
{
    public class TxtFileAnalyzer : FileAnalyzer ,IFileAnalysis
    {
        public void AnalyzeFile(FileInfo fileInfo)
        {
            string fileString= File.ReadAllText(fileInfo.FullName);

            AnalysisResults results = new AnalysisResults();

            var words = fileString.Split(new char[] { ' ', '\n', '\r' });
            results.WordCount = words.Length;
            results.CharacterCount = fileString.Length;
            var lines = fileString.Split(new char[] {'\n'});
            results.LineCount = lines.Length;


            SetReults(results);
        }
        
    }
}
