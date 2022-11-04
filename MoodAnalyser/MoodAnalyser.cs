using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MoodAnalyser1.MoodAnalyserCustomException;

namespace MoodAnalyser1
{
    public class MoodAnalyser
    {
        //Class Field
        string Message;

        //Constructor with no Parameter- Default Constructor
        public MoodAnalyser()
        {
            Message = null;
        }

        //Parameterized Constructor
        public MoodAnalyser(string message)
        {
            Message = message;
        }

        public string AnalyseMood()
        {

            try
            {
                if (Message == null)
                {
                    throw new MoodAnalyserCustomException(ExceptionType.NULL_MESSAGE, "Mood Should Not be Null");
                }
                if (Message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(ExceptionType.EMPTY_MESSAGE, "Mood Should Not Be Empty");
                }
                if (Message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
