using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;

namespace TestMood
{
    [TestClass]
    public class UnitTest1
    {


        UC2MoodAnalyzer moodAnalyzer = null;
        public UnitTest1()
        {

        }
        //TC 1.1  
        [TestMethod]
        public void SadMood()
        {
            // Arrange
            string expected = "SAD";
            string message = "I am in Sad Mood";
            MoodAnalyzer moodAnalyse = new MoodAnalyzer(message);

            // Act
            string mood = moodAnalyse.AnalyseMood();

            // Assert
            Assert.AreEqual(expected, mood);
        }

       //TC 1.2
        [TestMethod]
        public void HappyMood()
        {
            // Arrange
            string expected = "HAPPY";
            string message = "I am in HAPPY Mood";
            MoodAnalyzer moodAnalyse = new MoodAnalyzer(message);

            // Act
            string mood = moodAnalyse.AnalyseMood();

            // Assert
            Assert.AreEqual(expected, mood);
        }
        // UC2 null message return happy
        [TestMethod]
        public void givenMood_WhenNull_ShouldReturnHappyMood()
        {
            // Arrange
            string expected = "Happy";
            moodAnalyzer = new UC2MoodAnalyzer(null);
            // Act
            string mood = moodAnalyzer.AnalyseMood();
            // Assert
            Assert.AreEqual(expected, mood);
        }
    }
}
