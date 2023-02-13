using System;
using System.Linq;
using System.Collections.Generic;

namespace Courses
{
    class Courses
    {
        static void Main()
        {
            Dictionary<string, int> coursesMembersCount = new Dictionary<string, int>();
            Dictionary<string, List<string>> coursesMembersNames = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine()
                .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            while (true)
            {
                if (input[0] == "end")
                {
                    break;
                }

                string inputCourseName = input[0];
                string inputStudentName = input[1];

                if (!coursesMembersCount.ContainsKey(inputCourseName))
                {
                    coursesMembersCount.Add(inputCourseName, 1);
                    coursesMembersNames.Add(inputCourseName, new List<string>());
                    coursesMembersNames[inputCourseName].Add(inputStudentName);
                }
                else
                {
                    coursesMembersCount[inputCourseName]++;
                    coursesMembersNames[inputCourseName].Add(inputStudentName);
                }

                input = Console.ReadLine()
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            /*foreach (var course in coursesMembersCount.OrderByDescending(course => course.Value))
            {
                Console.WriteLine($"{course.Key}: {course.Value}");
                foreach (var courseName in coursesMembersNames)
                {
                    if (course.Key == courseName.Key)
                    {
                        foreach (var name in courseName.Value.OrderBy(x => x))
                        {
                            Console.WriteLine($"-- {name}");
                        }
                    }
                }
            }*/
            foreach (var course in coursesMembersCount)
            {
                Console.WriteLine($"{course.Key}: {course.Value}");
                foreach (var courseName in coursesMembersNames)
                {
                    if (course.Key == courseName.Key)
                    {
                        foreach (var name in courseName.Value)
                        {
                            Console.WriteLine($"-- {name}");
                        }
                    }
                }
            }
        }
    }
}
