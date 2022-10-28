
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
            MoodAnalyser MoodCheck = new MoodAnalyser(Message);

            string expected = "SAD";

            //Act
            string actual = MoodCheck.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void GivenHappyMood_ShouldReturn_Happy()
        {
            //Arrange
            string Message = "I am om Happy Mood";
            MoodAnalyser MoodCheck = new MoodAnalyser(Message);
            string expected = "HAPPY";

            //Act
            string actual = MoodCheck.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }


    }
      
    
}