﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Classes
{
    public class Playlist
    {
        public string Name { get; set; }
        public List<Song> Songs { get; set; }

        public Playlist(string name)
        {
            this.Name = name;
            this.Songs = new List<Song>();
        }

    }
}
