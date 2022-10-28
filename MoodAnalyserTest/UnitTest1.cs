
using MoodAnalyser1;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenNull_ShouldReturn_Happy()

        {
            //Arrange
            string Message = null;
            MoodAnalyser MoodCheck = new MoodAnalyser(Message);

            string expected = "HAPPY";

            //Act
            string actual = MoodCheck.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }



    }
      
    
}