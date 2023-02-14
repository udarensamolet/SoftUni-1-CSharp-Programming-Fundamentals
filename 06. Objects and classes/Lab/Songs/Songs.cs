using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    class Songs
    {
        static void Main()
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            string[] input = new string[numberOfSongs];
            List<Song> songsList = new List<Song>();
            for (int i = 0; i < numberOfSongs; i++)
            {
                input[i] = Console.ReadLine();
                string[] songInfo = input[i].Split('_', StringSplitOptions.RemoveEmptyEntries);
                Song inputSong = new Song(songInfo[0], songInfo[1], songInfo[2]);
                songsList.Add(inputSong);
            }
            string whatToPrint = Console.ReadLine();

            foreach (var song in songsList)
            {
                if (whatToPrint == "all")
                {
                    Console.WriteLine(song.Name);
                }
                else
                {
                    if (whatToPrint == song.TypeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
