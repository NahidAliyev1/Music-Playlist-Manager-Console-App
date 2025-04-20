using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Playlist_Manager_Console_App.Models;

public class Playlist
{
    public int Id { get; set; }
    public string PlaylistName { get; set; }
    public List<Song> Songs { get; set; }

    public Playlist(int id,string playlistname)
    {
        Id = id;
        PlaylistName = playlistname;
        Songs = new List<Song>();
    }
}
