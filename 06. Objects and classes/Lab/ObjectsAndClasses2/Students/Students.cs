using System;
using System.Linq;
using System.Collections.Generic;

namespace Students
{
    class Students
    {
        static void Main()
        {
            List<Student> studentsList = new List<Student>();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }
                else
                {
                    string[] studentInfo = input
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    Student student = new Student(studentInfo[0], studentInfo[1], Convert.ToInt32(studentInfo[2]), studentInfo[3]);

                    studentsList.Add(student);
                }
            }

            string townToPrint = Console.ReadLine();

            foreach (var student in studentsList)
            {
                if (townToPrint == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
