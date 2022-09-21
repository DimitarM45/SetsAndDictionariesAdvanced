using System;
using System.Linq;
using System.Collections.Generic;

namespace AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int studentCount = int.Parse(Console.ReadLine());

                Dictionary<string, List<decimal>> gradesByStudent = new Dictionary<string, List<decimal>>();

                for (int i = 1; i <= studentCount; i++)
                {
                    string[] studentInfo = Console.ReadLine().Split();

                    string studentName = studentInfo[0];

                    decimal studentGrade = decimal.Parse(studentInfo[1]);

                    if (!gradesByStudent.ContainsKey(studentName))
                        gradesByStudent.Add(studentName, new List<decimal>());

                    gradesByStudent[studentName].Add(studentGrade);
                }

                foreach (var student in gradesByStudent)
                {
                    Console.Write($"{student.Key} -> ");

                    foreach (var grade in student.Value)
                        Console.Write($"{grade:f2} ");

                    Console.Write($"(avg: {student.Value.Average():f2})");

                    Console.WriteLine();
                }
            }
        }
    }
}
