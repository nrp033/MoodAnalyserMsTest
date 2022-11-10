
using MoodAnalyser1;
using System;
using System.Globalization;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;

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
        //TC-4.3 should throw NO_SUCH_CONTRUCTOR exception.
        [TestMethod]
        public void GivenImproperConstructor_Shouldthrow_MoodAnalysisException()
        {
            string expected = "Constructor is Not Found";
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser();
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser1.MoodAnalyzer", "MoodAnalyser");
            }
            catch (MoodAnalyserCustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        //TC 5.1 :  Given MoodAnalyser Class Name When Proper Should Returns MoodAnalyser Object
        [TestMethod]
        public void GivenMoodAnalyserClassName_WhenProper_ShouldReturns_MoodAnalyserObject()
        {
            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterizedConstructor("MoodAnalyser1.MoodAnalyser", "MoodAnalyser", "HAPPY");
            expected.Equals(obj);
        }


        //Test Case 5.2 Given improper Class Name Should Throw Excepion

        [TestMethod]
        public void GivenClassNameWhenImproper_ShouldThrowMoodAnalysisException_NoSuchClassFound()
        {
            try
            {
                //Arrange
                string className = "DemoNamespace.MoodAnalyser";
                string constructorName = "MoodAnalyser";


                //Act
                object actual = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterizedConstructor(className, constructorName, "HAPPY");


            }
            catch (MoodAnalyserCustomException e)
            {
                //Assert
                Assert.AreEqual("Class not Found", e.Message);
            }

        }


        //Test Case 5.3 Given improper Constructor Name Should Throw Excepion

        [TestMethod]
        public void GivenConstructorNameWhenImproper_ShouldThrowMoodAnalysisException_NoSuchMethodFound()
        {
            try
            {
                //Arrange
                string className = "MoodAnalyser1.MoodAnalyser";
                string constructorName = "DemoConstructorName";


                //Act
                object actual = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterizedConstructor(className, constructorName, "GOOD");


            }
            catch (MoodAnalyserCustomException e)
            {
                //Assert
                Assert.AreEqual("Constructor not Found", e.Message);
            }

        }



        //  TC 6.1 Given happy message using reflection when proper should return happy mood.
        [TestMethod]
        public void GivenHappyMessage_WhenUsingReflection_ThenShouldReturnHappyMood()
        {
            string expected = "HAPPY";
            object obj = MoodAnalyserFactory.InvokeAnalyseMood("HAPPY", "AnalyseMood");
            Assert.AreEqual(expected, obj); 
        }

        //Test Case 6.2 Given Improper Method Should throw Mood Analysis Exception

        [TestMethod]
        public void GivenImproperMethod_ShouldThrowException()
        {
            //Arrange
            string expected = "Method Not Found";
            try
            {
               //Act
                string mood = MoodAnalyserFactory.InvokeAnalyseMood("Happy", "AnalyseChecking");     //passing Wrong MethodName
            }
            catch (MoodAnalyserCustomException e)
            {

                //Assert
                Assert.AreEqual(expected, e.Message);
            }
        }




    }


}