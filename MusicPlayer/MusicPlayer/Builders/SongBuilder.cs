using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicPlayer.Classes;

namespace MusicPlayer.Builders
{
    public class SongBuilder
    {
        private Song song;

        public SongBuilder()
        {
            this.song = new Song();
        }

        public SongBuilder Title(string title)
        {
            this.song.Title = title;
            return this;
        }

        public SongBuilder Artist(string artist)
        {
            this.song.Artist = artist;
            return this;
        }

        public SongBuilder Genre(Genre genre)
        {
            this.song.Genre = genre;
            return this;
        }

        public SongBuilder Album(string album)
        {
            this.song.Album = album;
            return this;
        }

        public SongBuilder Duration(int duration)
        {
            this.song.duration = duration;
            return this;
        }

        public Song Build()
        {
            return this.song;
        }
    }
}
