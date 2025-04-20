using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Music_Playlist_Manager_Console_App.Models;

namespace Music_Playlist_Manager_Console_App.PlaylistService;

public class Playlistservice
{
    private List<Playlist> playlists = new List<Playlist>();
    private int _idCounter = 1;

    public void CreatePlaylist(Playlist playlist)
    {
        playlists.Add(playlist);
        _idCounter++;
        Console.WriteLine("Playlist ugurla elave olundu");
    }
    public List<Playlist> GetAllPlaylists()
    {
        return playlists;
    }
    public Playlist UpdatePlaylist(int id,string playlistname)
    {
        var playlist = playlists.FirstOrDefault(p => p.Id == id);
        if (playlist is not null)
        {
            playlist.PlaylistName = playlistname;
            return playlist;

        }
        throw new Exception("Xeta bas verdi playlistde");
    }
    public void DeletePlaylist(int id,string playlistname)
    {
        var playlist = playlists.FirstOrDefault(p => p.Id == id);
        if (playlist is not null)
        {
            playlists.Remove(playlist);

        }
    }
    public void AddSongPlaylist(int id,Song song)
    {
        var songplaylist = playlists.FirstOrDefault(s => s.Id == id);
        if (songplaylist is not null)
        {
            playlists.Add(songplaylist);

        }
    }
    //Əlavə olaraq Playlistdəki mahnıların filterlə axtarışı(Artist adı, Mahnı adı və ya Janr)

    public List<Song> SearchSongForPlaylist(int id,string SongName, List<string> ArtistName)
    {

        return null;
    }





}
