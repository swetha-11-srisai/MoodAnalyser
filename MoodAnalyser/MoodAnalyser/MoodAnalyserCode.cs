using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    class MoodAnalyserCode
    {
        public string AnalyseMood(string Message)
        {
            if (Message.Contains("Sad"))
                return  "Sad";
            else
                return "Happy";
        }
    }
}
