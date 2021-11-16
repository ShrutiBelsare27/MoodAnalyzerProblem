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

   
        // 3.1 null mood
    
        [TestMethod]
        public void Given_NULL_Mood_Should_Throw_MoodAnalysisException()
        {
            try
            {
                string message = null;
                UC3MoodAnalyse moodAnalyse = new UC3MoodAnalyse(message);
                string mood = moodAnalyse.AnalyseMood();
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }

     
        //3.2 Empty mood
     
        [TestMethod]
        public void Given_Empty_Mood_Should_Throw_MoodAnalysisException_Indicating_EmptyMood()
        {
            try
            {
                string message = "";
                UC3MoodAnalyse moodAnalyse = new UC3MoodAnalyse(message);
                string mood = moodAnalyse.AnalyseMood();
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }


        // Test Case 4.1 Given UC2MoodAnalyzer Class Name Should Return UC2MoodAnalyzer Object.

        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            object expected = new UC3MoodAnalyse();
            object obj = MoodAnalyseFactory.CreateMoodAnalyse("MoodAnalyzerProblem.UC3MoodAnalyse", "UC3MoodAnalyse");
            expected.Equals(obj);
        }

       
        // Test Case 4.2 Given Improper Class Name Should throw MoodAnalyssiException.
    
        [TestMethod]
        public void GivenImproperClassNameShouldThrowMoodAnalysisException()
        {
            string expected = "Class Not Found";
            try
            {
                object moodAnalyseObject = MoodAnalyseFactory.CreateMoodAnalyse("MoodAnalyzerProblem.DemoClass", "DemoClass");

            }
            catch (MoodAnalysisException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

       
        /// Test Case 4.3 Given Improper Constructor should throw MoodAnalysisException.
       
        [TestMethod]
        public void GivenImproperConstructorShouldThrowMoodAnalysisException()
        {

            string expected = "Constructor is Not Found";
            try
            {
                object moodAnalyseObject = MoodAnalyseFactory.CreateMoodAnalyse("DemoClass", "UC3MoodAnalyse");
            }
            catch (MoodAnalysisException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
      
        /// Test Case 5.1 Given MoodAnalyse Class Name Should Return MoodAnalyser Object.
       
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new UC3MoodAnalyse("HAPPY");
            object obj = MoodAnalyseFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerProblem.UC3MoodAnalyse", "UC3MoodAnalyse");
            expected.Equals(obj);
        }

       
        /// Test Case 5.2 Given Improper Class Name Should throw MoodAnalyssiException.
   
        [TestMethod]
        public void GivenImproperClassNameShouldThrowMoodAnalysisException_UsingParameterizedConstructor()
        {
            string expected = "Class Not Found";
            try
            {
                object moodAnalyseObject = MoodAnalyseFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerProblem.DemoClass", "UC2MoodAnalyzer");

            }
            catch (MoodAnalysisException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

     
        /// Test Case 5.3 Given Improper Constructor Name Should throw MoodAnalyssiException.

        [TestMethod]
        public void GivenImproperConstructorNameShouldThrowMoodAnalysisException_UsingParameterizedConstructor()
        {
            string expected = "Constructor is Not Found";
            try
            {
                object moodAnalyseObject = MoodAnalyseFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerProblem.UC3MoodAnalyse", "DemoConstructor");

            }
            catch (MoodAnalysisException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }


        
        // Test Case 6.1 Given Happy Should Return Happy.
     
        [TestMethod]
        public void GivenHappyMoodShouldReturnHappy()
        {
            string expected = "HAPPY";
            string mood = MoodAnalyseFactory.InvokeAnalyseMood("Happy", "AnalyseMood");
            Assert.AreEqual(expected, mood);
        }

       
        // Test Case 6.2 Given Happy Should Return Happy.
      
        [TestMethod]
        public void Given_ImproperMethodName_Should_Throw_MoodAnalysisException()
        {
            string expected = "Method is Not Found";
            try
            {
                string mood = MoodAnalyseFactory.InvokeAnalyseMood("Happy", "DemoMethod");
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }
    }
}
