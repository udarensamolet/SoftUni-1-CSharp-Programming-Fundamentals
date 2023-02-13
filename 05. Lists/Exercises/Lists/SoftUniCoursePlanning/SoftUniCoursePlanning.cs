using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class SoftUniCoursePlanning
    {
        static void Main()
        {
            List<string> courses = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string[] commands = Console.ReadLine()
                    .Split(new char[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (commands[0] == "course" && commands[1] == "start")
                {
                    break;
                }

                if (commands[0] == "Add")
                {
                    if (!courses.Contains(commands[1]))
                    {
                        courses.Add(commands[1]);
                    }
                }
                else if (commands[0] == "Insert")
                {
                    if (!courses.Contains(commands[1]))
                    {
                        courses.Insert(Convert.ToInt32(commands[2]), commands[1]);
                    }
                }
                else if (commands[0] == "Remove")
                {
                    if (courses.Contains(commands[1]))
                    {
                        string exercise = $"{commands[1]}-Exercise";
                        if (courses.Contains(exercise))
                        {
                            courses.Remove(exercise);
                        }
                        courses.Remove(commands[1]);
                    }
                }
                else if (commands[0] == "Swap")
                {
                    if (courses.Contains(commands[1]) && courses.Contains(commands[2]))
                    {
                        int indexFirst = courses.IndexOf(commands[1]);
                        int indexSecond = courses.IndexOf(commands[2]);

                        string temp = courses[indexFirst];
                        courses[indexFirst] = courses[indexSecond];
                        courses[indexSecond] = temp;


                        string exerciseFirst = $"{commands[1]}-Exercise";
                        if (courses.Contains(exerciseFirst))
                        {
                            courses.Remove(exerciseFirst);
                            courses.Insert(indexSecond + 1, exerciseFirst);
                        }

                        string exerciseSecond = $"{commands[2]}-Exercise";
                        if (courses.Contains(exerciseSecond))
                        {
                            courses.Remove(exerciseSecond);
                            courses.Insert(indexFirst + 1, exerciseSecond);
                        }

                    }
                }
                else if (commands[0] == "Exercise")
                {
                    string exerciseName = $"{commands[1]}-Exercise";
                    if (courses.Contains(commands[1]) && !courses.Contains(exerciseName))
                    {
                        int indexLesson = courses.IndexOf(commands[1]);
                        courses.Insert(indexLesson + 1, exerciseName);
                    }
                    else if (!courses.Contains(commands[1]))
                    {
                        courses.Add(commands[1]);
                        courses.Add(exerciseName);
                    }
                }
            }

            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{courses[i]}");
            }
        }
    }
}
