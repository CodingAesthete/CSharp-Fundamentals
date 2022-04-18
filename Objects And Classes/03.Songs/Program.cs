using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                List<string> input = Console.ReadLine().Split("_").ToList();
                Song song = new Song(input[0],input[1],input[2]);
                songs.Add(song);
            }

            string type = Console.ReadLine();

            PrintSongs(songs, type);
        }

        private static void PrintSongs(List<Song> songs, string type)
        {
            if (type=="all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(String.Join(Environment.NewLine,song.Name));
                }
            }
            else
            {
                songs = songs.Where(s => s.TypeList == type).ToList();
                foreach (var song in songs)
                {
                    Console.WriteLine(String.Join(Environment.NewLine, song.Name));
                }
            }
        }

        public class Song
        {
            public Song(string typeList,string name, string time)
            {
                TypeList = typeList;
                Name = name;
                Time = time;
            }
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
        }
    }
}
