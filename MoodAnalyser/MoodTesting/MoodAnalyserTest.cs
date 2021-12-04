using NUnit.Framework;

namespace MoodTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenSadShouldReturnSad()
        {
            MoodAnalyserCode moodAnalyser = new MoodAnalyserCode();
            string expected = "Sad";
            string result = moodAnalyser.AnalyseMood("I am in Sad mood");
            Assert.AreEqual(expected, result);
        }
        public void GivenSadShouldReturnAnyMood()
        {
            MoodAnalyserCode moodAnalyser = new MoodAnalyserCode();
            string expected = "Happy";
            string result = moodAnalyser.AnalyseMood("I am in Any mood");
            Assert.AreEqual(expected, result);
        }
    }
}