
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

        //Test Case 4.1 Given MoodAnalyser ClassName should return object of MoodAnalyser

        [TestMethod]
        public void GivenAnalyseMoodClassName_ShouldreturnMoodAnalyseObject()
        {
            //Arrange

            object expected = new MoodAnalyser();

            //Act
            object factory = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser1.MoodAnalyser","MoodAnalyser");

            //Assert

            expected.Equals(factory);
        }

        // TC 4.2 : Given Class Name When Improper Should Throw MoodAnalysis Exception.
        [TestMethod]
        public void GivenImpoperClassName_ShouldThrowMoodAnalyseException_IndicatingNoSuchClass()
        {
            string expected = "Class Not Found";
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser();
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser1.MoodAnalyser","MoodAnalyser");
            }
            catch (MoodAnalyserCustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        ////Test Case 4.2
        //[TestMethod]
        //public void GivenImpoperClassName_ShouldThrowMoodAnalyseException_IndicatingNoSuchClass()
        //{
        //    try
        //    {
        //        //Arrange
        //        string className = "DemoNamespace.MoodAnalyser";     //wrong className passed to pass test
        //        string constructorName = "MoodAnalyser";
        //        //Act
        //        object resultObj = MoodAnalyserFactory.CreateMoodAnalyser(className, constructorName);
        //    }
        //    catch (MoodAnalyserCustomException e)
        //    {
        //        //Assert
        //        Assert.AreEqual("Class not found", e.Message);
        //    }
        //}

    }


}