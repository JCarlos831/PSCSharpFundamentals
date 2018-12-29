using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Grades
{
    public class GradeBook : GradeTracker
    {
        public GradeBook()
        {
            _name = "Empty";
            _grades = new List<float>();
        }

        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("GradeBook::ComputeStatistics");

            GradeStatistics stats = new GradeStatistics();

            float sum = 0;

            foreach (float grade in _grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            stats.AverageGrade = sum / _grades.Count;

            return stats;
        }

        public override void AddGrade(float grade)
        {
            _grades.Add(grade);
        }

        public override IEnumerator GetEnumerator()
        {
            return _grades.GetEnumerator();
        }
        
        protected readonly List<float> _grades;

        public override void WriteGrades(TextWriter destination)
        {
            for (int i = 0; i < _grades.Count; i++)
            {
                destination.WriteLine(_grades[i]);
            }
        }
    }
}