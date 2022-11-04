
using MoodAnalyser1;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
       //UC 3.0
        [TestMethod]
        public void InformUser_ifGive_invalidMoodLikeNullorEmptyby_CustomException()

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