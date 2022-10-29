
using MoodAnalyser1;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenNullorEmptyMessage_ShouldReturnExceptionHandleMessage()

        {
            //Arrange
            string Message = "";
            MoodAnalyser MoodCheck = new MoodAnalyser(Message);

            string expected = "Mood Should Not Be Empty";

            //Act
            string actual = MoodCheck.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }



    }
      
    
}