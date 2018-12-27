using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            GradeBook book = new GradeBook();
            
            book.NameChanged += OnNameChanged;
//            book.NameChanged += OnNameChanged2;
//            book.NameChanged += OnNameChanged2;
//            book.NameChanged -= OnNameChanged2;
            
            book.Name = "Juan's Grade Book";
            book.Name = "Grade Book";
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Average grade", stats.AverageGrade);
            WriteResult("Highest grade", (int) stats.HighestGrade);
            WriteResult("Lowest grade", (int) stats.LowestGrade);

        }

        static void OnNameChanged(object sender, NameChangedEventsArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }
        
//        static void OnNameChanged2(string existingName, string newName)
//        {
//            Console.WriteLine("***");
//        }
        
        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description} : {result}");
        }
    }
}