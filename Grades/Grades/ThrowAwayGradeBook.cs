using System;

namespace Grades
{
    public class ThrowAwayGradeBook : GradeBook
    {
        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("ThrowAwayGradeBook::ComputeStatistics");
            float lowest = float.MaxValue;

            foreach (float grade in _grades)
            {
                lowest = Math.Min(grade, lowest);
            }

            _grades.Remove(lowest);
            
            return base.ComputeStatistics();
        }
    }
}