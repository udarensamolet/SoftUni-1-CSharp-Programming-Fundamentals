using System;
using System.Linq;

namespace ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main()
        {
            int[] arrInput = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "end")
                {
                    Console.WriteLine($"[{string.Join(", ", arrInput)}]");
                    break;
                }

                else if (command[0] == "exchange")
                {
                    arrInput = Exchange(arrInput, Convert.ToInt32(command[1]));
                }
                else if (command[0] == "max")
                {
                    if (command[1] == "even")
                    {
                        FindMaxEvenIndex(arrInput);
                    }
                    else if (command[1] == "odd")
                    {
                        FindMaxOddIndex(arrInput);
                    }
                }
                else if (command[0] == "min")
                {
                    if (command[1] == "even")
                    {
                        FindMinEvenIndex(arrInput);
                    }
                    else if (command[1] == "odd")
                    {
                        FindMinOddIndex(arrInput);
                    }
                }
                else if (command[0] == "first")
                {
                    if (command[2] == "even")
                    {
                        FindFirstCountEven(arrInput, Convert.ToInt32(command[1]));
                    }
                    else if (command[2] == "odd")
                    {
                        FindFirstCountOdd(arrInput, Convert.ToInt32(command[1])); ;
                    }
                }
                else if (command[0] == "last")
                {
                    if (command[2] == "even")
                    {
                        FindLastCountEven(arrInput, Convert.ToInt32(command[1]));
                    }
                    else if (command[2] == "odd")
                    {
                        FindLastCountOdd(arrInput, Convert.ToInt32(command[1])); ;
                    }
                }

            }
        }
        static int[] Exchange(int[] oldArr, int index)
        {
            int[] newArr = new int[oldArr.Length];
            if (index < 0 || index > oldArr.Length - 1)
            {
                Console.WriteLine("Invalid index");
                return oldArr;
            }
            else
            {
                //filling in the first half
                for (int i = 0; i < oldArr.Length - index - 1; i++)
                {
                    newArr[i] = oldArr[i + index + 1];
                }
                //filling in the second half
                for (int i = oldArr.Length - index - 1; i < oldArr.Length; i++)
                {
                    newArr[i] = oldArr[i - (oldArr.Length - index - 1)];
                }
                oldArr = newArr;
                return oldArr;
            }
        }
        static void FindMaxEvenIndex(int[] arr)
        {
            int maxEvenIndex = int.MinValue;
            int maxNumber = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] >= maxNumber)
                {
                    maxNumber = arr[i];
                    maxEvenIndex = i;
                }
            }
            if (maxEvenIndex == int.MinValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxEvenIndex);
            }

        }
        static void FindMaxOddIndex(int[] arr)
        {
            int maxOddIndex = int.MinValue;
            int maxNumber = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0 && arr[i] >= maxNumber)
                {
                    maxNumber = arr[i];
                    maxOddIndex = i;
                }
            }
            if (maxOddIndex == int.MinValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxOddIndex);
            }
        }
        static void FindMinEvenIndex(int[] arr)
        {
            int minEvenIndex = int.MaxValue;
            int minNumber = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] <= minNumber)
                {
                    minNumber = arr[i];
                    minEvenIndex = i;
                }
            }
            if (minEvenIndex == int.MaxValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minEvenIndex);
            }
        }
        static void FindMinOddIndex(int[] arr)
        {
            int minOddIndex = int.MaxValue;
            int minNumber = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0 && arr[i] <= minNumber)
                {
                    minNumber = arr[i];
                    minOddIndex = i;
                }
            }
            if (minOddIndex == int.MaxValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minOddIndex);
            }
        }
        static void FindFirstCountEven(int[] arr, int n)
        {
            int countFirstEven = -1;
            int?[] newEvenArr = new int?[n];
            if (n > arr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        countFirstEven++;
                        newEvenArr[countFirstEven] = arr[i];
                        if (countFirstEven == n - 1)
                        {
                            break;
                        }
                    }
                }
                if (countFirstEven == -1)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.WriteLine($"[{string.Join(", ", newEvenArr.Where(x => x.HasValue))}]");
                }
            }

        }
        static void FindFirstCountOdd(int[] arr, int n)
        {
            int countFirstOdd = -1;
            int?[] newOddArr = new int?[n];

            if (n > arr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        countFirstOdd++;
                        newOddArr[countFirstOdd] = arr[i];
                        if (countFirstOdd == n - 1)
                        {
                            break;
                        }
                    }
                }

                if (countFirstOdd == -1)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.WriteLine($"[{string.Join(", ", newOddArr.Where(x => x.HasValue))}]");
                }
            }

        }
        static void FindLastCountEven(int[] arr, int n)
        {
            int countLastEven = -1;
            int?[] newEvenArr = new int?[n];
            if (n > arr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] % 2 == 0)
                    {
                        countLastEven++;
                        newEvenArr[countLastEven] = arr[i];
                        if (countLastEven == n - 1)
                        {
                            break;
                        }
                    }
                }
                Array.Reverse(newEvenArr);
                if (countLastEven == -1)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.WriteLine($"[{string.Join(", ", newEvenArr.Where(x => x.HasValue))}]");
                }
            }
        }
        static void FindLastCountOdd(int[] arr, int n)
        {
            int countLastOdd = -1;
            int?[] newOddArr = new int?[n];

            if (n > arr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] % 2 != 0)
                    {
                        countLastOdd++;
                        newOddArr[countLastOdd] = arr[i];
                        if (countLastOdd == n - 1)
                        {
                            break;
                        }
                    }
                }
                Array.Reverse(newOddArr);
                if (countLastOdd == -1)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.WriteLine($"[{string.Join(", ", newOddArr.Where(x => x.HasValue))}]");
                }
            }
        }
    }
}

