namespace GradeBook
{
    using System.Collections.Generic;
    class Book
    {
        private List<double> grades;
        private string name;
        private double lowestGrade = double.MaxValue;
        private double highestGrade = double.MinValue;
        private double averageGrade = 0.0;

        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            foreach(var grade in grades){
                // get lowest grade
                if (grade < lowestGrade)
                {
                    lowestGrade = grade;
                }
                // highest grade
                if (grade > highestGrade)
                {
                    highestGrade = grade;
                }
                result += grade;
            }
            // average grade
            averageGrade = result / grades.Count;

            System.Console.WriteLine($"The lowest grade is {lowestGrade}");
            System.Console.WriteLine($"The highest grade is {highestGrade}");
            System.Console.WriteLine($"The average grade is {averageGrade}");
        }
    }
}