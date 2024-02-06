using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Classes
{
    public class MusicPlayerApp
    {
        public List<Playlist> Playlists { get; set; }

        public MusicPlayerApp()
        {
            this.Playlists = new List<Playlist>();
        }

        public void AddPlaylist(Playlist playlist)
        {
            this.Playlists.Add(playlist);
        }

        public void RemovePlaylist(Playlist playlist)
        {
            this.Playlists.Remove(playlist);
        }

        public void RemovePlaylist(string name)
        {
            this.Playlists.RemoveAll(p => p.Name == name);
        }

        public void RemovePlaylist(int index)
        {
            this.Playlists.RemoveAt(index);
        }

        public void Play()
        {
            Console.WriteLine("Playing...");
        }

        public void Pause()
        {
            Console.WriteLine("Paused...");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped...");
        }
    }
}
