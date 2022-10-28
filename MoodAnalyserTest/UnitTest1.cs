
using MoodAnalyser1;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
            [TestMethod]
            public void GivenMood_ShouldReturn_SAD_MOOD()
        
            {
                //Arrange
                string Message = "I am in Sad Mood";
                MoodAnalyser MoodCheck = new MoodAnalyser();

                string expected = "SAD";

                //Act
                string actual = MoodCheck.AnalyseMood(Message);

                //Assert
                Assert.AreEqual(expected, actual);
            }


            [TestMethod]
            public void GivenAnyMood_ShouldReturn_Happy()
            {
                //Arrange
                string Message = "I am In Any Mood";
                MoodAnalyser MoodCheck = new MoodAnalyser();
                string expected = "HAPPY";

                //Act
                string actual = MoodCheck.AnalyseMood(Message);

                //Assert
                Assert.AreEqual(expected, actual);
            }

    }
      
    
}