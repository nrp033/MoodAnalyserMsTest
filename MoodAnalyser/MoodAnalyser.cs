using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (Message.ToLower().Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
