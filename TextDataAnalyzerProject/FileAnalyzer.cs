using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDataAnalyzerProject
{
    public class FileAnalyzer
    {
        private AnalysisResults _results;

        public AnalysisResults GetReults()
        {  
            return _results;

        }
        public void SetReults(AnalysisResults results) 
        {
            _results = results;
        
        }
    }
}
