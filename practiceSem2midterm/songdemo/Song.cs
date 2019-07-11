using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace songdemo
{
    [Flags]
    enum SongGenre
    {
        Unclassified = 0,Pop = 1,Rock = 2,Blues = 4,Country = 8,Metal = 16,Soul = 32
    }
    class Song
    {
        public string Artist { get; }
        public string Title { get; }
        public double Length { get; }
        public SongGenre Genre { get; }

        public Song(string title, string artist, double length, SongGenre genre)
        {
            Title = title;
            Artist = artist;
            Length = length;
            Genre = genre;
        }
        public override string ToString()
        {
            return $"{Title} {Artist} {Length} {Genre}";
        }
       
    }
}
