using System;
using System.Linq;
using System.Collections.Generic;

namespace Students2
{
    class Students2
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

                    string firstName = studentInfo[0];
                    string lastName = studentInfo[1];
                    int age = Convert.ToInt32(studentInfo[2]);
                    string homeTown = studentInfo[3];

                    if (IsStudentExisting(studentsList, firstName, lastName))
                    {
                        GetStudent(studentsList, firstName, lastName).Age = age;
                        GetStudent(studentsList, firstName, lastName).HomeTown = homeTown;
                    }
                    else
                    {
                        Student student = new Student(firstName, lastName, age, homeTown);
                        studentsList.Add(student);
                    }
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

        static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;
            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        }
    }
}
