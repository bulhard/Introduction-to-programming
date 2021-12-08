using System;
using System.Collections.Generic;
using System.IO;

namespace Lesson_09_Files
{
    public static class Exercise2
    {
        public static void ProcessStudents(string workingFolder)
        {
            List<Student> studentsList = ReadStudents(workingFolder);

            ReadScores(workingFolder, studentsList);

            string studentNumber = SearchStudentNumber(studentsList);

            ExportStudent(workingFolder, studentNumber, studentsList);

            Console.ReadLine();
        }

        private static List<Student> ReadStudents(string workingFolder)
        {
            List<Student> studentsList = new List<Student>();

            string studentsFile = Path.Combine(workingFolder, "StudentsDatabase", "students.txt");

            string[] studentsLines = File.ReadAllLines(studentsFile);

            foreach (var line in studentsLines)
            {
                var data = line.Split("|");

                Student newStudent = new Student
                {
                    FirstName = data[0].Trim(),
                    LastName = data[1].Trim(),
                    StudentNumber = data[2].Trim()
                };

                studentsList.Add(newStudent);
            }

            return studentsList;
        }

        private static void ReadScores(string workingFolder, List<Student> studentsList)
        {
            var scoresFile = Path.Combine(workingFolder, "StudentsDatabase", "scores.txt");
            var scoresLines = File.ReadAllLines(scoresFile);
            var courseName = "";

            foreach (var line in scoresLines)
            {
                if (line.StartsWith("Course"))
                {
                    courseName = line.Split(" ")[1];
                }
                else
                {
                    var data = line.Split("|");
                    var studentNumber = data[0].Trim();
                    var studentScore = int.Parse(data[1]);

                    // Find student with current studentNumber, in this case I'm using Linq for simplicity, however same can be achieved using loop
                    var student = studentsList.Find(s => s.StudentNumber == studentNumber);

                    if (student != null)
                    {
                        student.Scores.Add(new StudentScore
                        {
                            CourseName = courseName,
                            Score = studentScore
                        });
                    }
                }
            }
        }

        private static string SearchStudentNumber(List<Student> studentsList)
        {
            Console.WriteLine("Please enter student number: ");
            return Console.ReadLine();
        }

        private static void ExportStudent(string workingFolder, string studentNumber, List<Student> studentsList)
        {
            // Find student with current studentNumber, in this case I'm using Linq for simplicity, however same can be achieved using loop
            var student = studentsList.Find(s => s.StudentNumber == studentNumber);

            if (student != null)
            {
                string fileName = Path.Combine(workingFolder, "StudentsDatabase", student.StudentNumber + ".txt");

                File.WriteAllText(fileName, student.ToString());
            }
        }
    }
}