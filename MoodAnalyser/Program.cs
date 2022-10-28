using System.Net.Http.Headers;

namespace MoodAnalyser1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            MoodAnalyser moodcheck=new MoodAnalyser("sad");
            string result = moodcheck.AnalyseMood();

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}