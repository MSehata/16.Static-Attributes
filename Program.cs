using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Static_Attributes
{
    internal class songs
    {
        public string tittle;
        public string artist;
        public double duration;

        public static int songCount = 0;

        public songs(string aTittle, string anArtist, double aDuration) 
        {
            this.tittle = aTittle;
            this.artist = anArtist;
            this.duration = aDuration;
            songCount++;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            songs holiday = new songs("Holiday", "Green Day", 6.8);
            songs khashmir = new songs("Khashmir", "Led Zeppelin", 4.58);

            Console.WriteLine("Song count: " + songs.songCount);
            Console.ReadLine();
        }
    }
}
