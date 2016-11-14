using System;
// using System.Speech;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
        //    SpeechSynthesizer 
           GradeBook gradeBook = new GradeBook();
           gradeBook.addGrade(65);
           gradeBook.addGrade(99);

           GradeStatistics stats = gradeBook.computeStatistics();

           System.Console.WriteLine(stats.returnStatistics());
        }
    }
}
