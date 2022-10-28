
using MoodAnalyser1;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMood_ShouldReturn_SAD_MOOD()
        {
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

        }
      
    }
}