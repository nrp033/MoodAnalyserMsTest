using System.Net.Http.Headers;

namespace MoodAnalyser1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            string mood = null;
            MoodAnalyser moodcheck=new MoodAnalyser(mood);
            string result = moodcheck.AnalyseMood();

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}