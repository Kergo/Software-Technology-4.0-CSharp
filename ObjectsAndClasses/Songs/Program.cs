using System;
using System.Linq;
using System.Collections.Generic;

namespace Songs
{
    public class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            int numSongs = int.Parse(Console.ReadLine());

            List <Song> songs = new List<Song>();

            for (int i = 0; i < numSongs; i++)
            {
                string[] data = Console.ReadLine().Split("_");

                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (var song in songs)
                {
                    System.Console.WriteLine(song.Name);
                }
            }
            else {
                List<Song> filteredSongs = songs
                    .Where(s => s.TypeList == typeList)
                    .ToList();

                foreach (var song in filteredSongs)
                {
                    System.Console.WriteLine(song.Name);
                }
            }        
        }
    }
}
