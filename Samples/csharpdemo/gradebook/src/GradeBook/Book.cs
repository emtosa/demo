namespace GradeBook
{
    using System;
    using System.Collections.Generic;
    public class Book
    {
        private List<double> grades;
        private string name;
        private double lowestGrade = double.MaxValue;
        private double highestGrade = double.MinValue;

        public double Average
        {
            get
            {
                var result = 0.0;
                if (grades.Count > 0)
                {
                    foreach (var grade in grades)
                    {
                        result += grade;
                    }
                    result /= grades.Count;
                }
                return result;
            }
        }

        public string Name
        {
            set {
                name = value;
            }
            get {
                return name;
            }
        }

        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.Low = double.MaxValue;
            result.High = double.MinValue;
            foreach (var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }
            result.Average = result.Average / grades.Count;
            return result;
        }
    }
}