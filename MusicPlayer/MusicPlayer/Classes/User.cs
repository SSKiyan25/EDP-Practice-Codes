using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Classes
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Playlist> Playlists { get; set; }
        public List<Song> Songs { get; set; }

        public User(string name, string email, string password)
        {
            this.Name = name;
            this.Email = email;
            this.Password = password;
        }
    }
}
