using System;
using System.Collections.Generic;

namespace Lesson_09_Files
{
    public class Student
    {
        public Student()
        {
            // Make sure a Scores object is created together with main object, so we put initialization in the constructor.
            Scores = new List<StudentScore>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StudentNumber { get; set; }

        public List<StudentScore> Scores { get; set; }

        public float AverageScore
        {
            get
            {
                if (Scores.Count > 0)
                {
                    float sumOfScores = 0;
                    foreach (var score in Scores)
                    {
                        sumOfScores += score.Score;
                    }

                    return sumOfScores / Scores.Count;
                }

                return 0;
            }
        }

        public override string ToString()
        {
            /*Ivan Petrov - average score 3
             * C# - 4
             * Java - 2*/

            string result = $"{FirstName} {LastName} - average score {AverageScore}";

            foreach (var score in Scores)
            {
                result += Environment.NewLine;
                result += $"{score.CourseName} - {score.Score}";
            }

            return result;
        }
    }
}