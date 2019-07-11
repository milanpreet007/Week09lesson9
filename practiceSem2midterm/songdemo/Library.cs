using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace songdemo
{
    static class Library
    {
        static List<Song> songs = new List<Song>();
        public static void DisplaySongs()
        {
            foreach(Song x in songs)
            {
                Console.WriteLine($"{x}");
            }
        }
        public static void DisplaySongs(double longerThan)
        {
            foreach (Song x in songs)
            {
                if (x.Length > longerThan)
                {
                    Console.WriteLine($"{x}");
                }
            }
        }
        public static void DisplaySongs(SongGenre genre)
        {
            foreach (Song x in songs)
            {
                if (genre == x.Genre)
                {
                    Console.WriteLine($"{x}");
                }
            }
        }
        public static void DisplaySongs(string artist)
        {
            foreach (Song x in songs)
            {
                if (artist == x.Artist)
                {
                    Console.WriteLine($"{x}");
                }
            }
        }
        public static void LoadSongs(string fileName)
        {
            string title, artist, genre, length;
            TextReader reader = new StreamReader(fileName);
            title = reader.ReadLine();
            while (title != null)
            {

                artist = reader.ReadLine();
                length = reader.ReadLine();
                genre = reader.ReadLine();
                songs.Add(new Song(title, artist, Convert.ToDouble(length), (SongGenre)Enum.Parse(typeof(SongGenre), genre)));
                title = reader.ReadLine();
            }
        }
    }
}
