using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Playlist_Manager_Console_App.Models;

public class Song
{
    public int Id { get; set; }
    public string SongName { get; set; }
    public List<string> ArtistName { get; set; }
    public GenreEnum Genre { get; set; }
    public int Duration { get; set; }

    public Song(int id,string songname,List<string> artistname,GenreEnum genre,int duration)
    {
        Id = id;
        SongName = songname;
        ArtistName = artistname;
        Genre = genre;
        Duration = duration;
            
    }
}

public enum GenreEnum
{
    Pop,
    Rock,
    Jazz,
    Classic
}
