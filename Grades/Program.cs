using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example of non-standard assembly included in a console program          
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello! This is a grade book program!");

            Gradebook book = new Gradebook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("Your average grade: " + stats.AverageGrade);
            Console.WriteLine("Your highest grade: " + stats.HighestGrade);
            Console.WriteLine("Your lowest grade: " + stats.LowestGrade);

        }
    }
}
