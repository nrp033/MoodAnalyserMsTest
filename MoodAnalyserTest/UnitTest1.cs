
using MoodAnalyser1;
using System.Globalization;

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



        //TestCase 3.1 Given Null Moood Should Return Mood Should Not be Null
        [TestMethod]
        public void GivenNullMood_ShouldReturn_MoodAnalysisException()
        {
            //Arrange
            // string Message = null;
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string expected = "Mood Should Not be Null";

            //Act
            string actual = moodAnalyser.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }


        //TestCase-3.2 Given Empty Mood Should Return Mood Should Not Be Empty
        [TestMethod]
        public void GivenEmptyMood_ShouldReturn_MoodAnalysisException()
        {
            //Arrange
            string Message ="";
            MoodAnalyser moodAnalyser = new MoodAnalyser(Message);
            string expected = "Mood Should Not Be Empty";

            //Act
            string actual = moodAnalyser.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }


}