using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Music_Playlist_Manager_Console_App.Models;

namespace Music_Playlist_Manager_Console_App.SongService;

public class Songservice
{
    private static int _idCounter = 1;
    private List<Song> songs = new List<Song>();
   public void AddSong(Song song)
    {
        songs.Add(song);
        _idCounter++;
        Console.WriteLine("Mahni ugurla elave olundu");
    }
    public List<Song> GetAllSong()
    {
        return songs;
    }
    public Song UpdateSong(int id, string name, List<string> artists, GenreEnum genre, int duration)
    {
        var song = songs.FirstOrDefault(s => s.Id == id);
        if (song is not null)
        {
            song.SongName = name;
            song.ArtistName = artists;
            song.Genre = genre;
            song.Duration = duration;

            return song;
        }
        
            throw new Exception("Xeta bas verdi mahnida");
    }
    public void DeleteSong(int id)
    {
        var song = songs.FirstOrDefault(s => s.Id == id);
        if (song is not null)
        {
            songs.Remove(song);
        }
    }


}
