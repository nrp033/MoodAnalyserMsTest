using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser1
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyser(string className, string constructorName)
        {
            try
            {


                Assembly assembly = Assembly.GetExecutingAssembly();

                Type moodAnalysetype = assembly.GetType(className);

                return Activator.CreateInstance(moodAnalysetype);
            }
            catch(Exception e)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
            }
        }
    }
}
