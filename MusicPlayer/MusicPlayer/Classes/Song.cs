using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Classes
{
    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public Genre? Genre { get; set; }
        public string Album { get; set; }
        public int duration { get; set; }

        public Song()
        {
            this.Title = string.Empty;
            this.Artist = string.Empty;
            this.Genre = null;
            this.Album = string.Empty;
            this.duration = 0;
        }
    }
}
