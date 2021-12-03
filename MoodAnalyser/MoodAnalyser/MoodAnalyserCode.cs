using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    class MoodAnalyserCode
    {
        public string AnalyzeMood(string message)
        {
            try
            {
                if (message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch (Exception)
            {
                return "Happy";
            }
        }
    }
}
