using System;
using System.Linq;
using System.Collections.Generic;

namespace Students
{
    class Students
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string firstname = input[0];
                string lastName = input[1];
                double grade = Convert.ToDouble(input[2]);

                Student student = new Student(firstname, lastName, grade);
                students.Add(student);
            }

            List<Student> sortedStudents = students.OrderByDescending(x => x.Grade).ToList();

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
