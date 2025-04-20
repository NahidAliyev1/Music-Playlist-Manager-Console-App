using Music_Playlist_Manager_Console_App.Models;
using Music_Playlist_Manager_Console_App.PlaylistService;
using Music_Playlist_Manager_Console_App.SongService;

namespace Music_Playlist_Manager_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Songservice songService = new Songservice();
            Playlistservice playlistService = new Playlistservice();

           
            List<string> artist1 = new List<string> { "Emin" };
            List<string> artist2 = new List<string> { "Ifrat" };
            List<string> artist3 = new List<string> { "Roya" };
            List<string> artist4 = new List<string> { "Yusif" };

          
            Song song1 = new Song(1, "Parol", artist1, GenreEnum.Classic, 140);
            Song song2 = new Song(2, "Gunes", artist2, GenreEnum.Jazz, 200);
            Song song3 = new Song(3, "Sema", artist3, GenreEnum.Rock, 180);
            Song song4 = new Song(4, "Son bir rica", artist4, GenreEnum.Pop, 130);

          
            songService.AddSong(song1);
            songService.AddSong(song2);
            songService.AddSong(song3);
            songService.AddSong(song4);

            Console.WriteLine("\n--- Bütün Mahnılar ---");
            foreach (var s in songService.GetAllSong())
            {
                Console.WriteLine($"ID: {s.Id}, Ad: {s.SongName}, Janr: {s.Genre}, Duration: {s.Duration}");
            }

            
            Console.WriteLine("\n--- Mahni Yenilenir (ID = 2) ---");
            songService.UpdateSong(2, "Gunəş", artist2, GenreEnum.Pop, 190);

          
            Console.WriteLine("\n--- Mahni Silinir (ID = 3) ---");
            songService.DeleteSong(3);

           
            Playlist playlist = new Playlist(1, "Mənim Playlistim");
            playlist.Songs.Add(song1);
            playlist.Songs.Add(song2);
            playlist.Songs.Add(song4);
            playlistService.CreatePlaylist(playlist);

            
            Console.WriteLine("\n--- Playlistlər ---");
            foreach (var p in playlistService.GetAllPlaylists())
            {
                Console.WriteLine($"Playlist: {p.PlaylistName}");
                foreach (var s in p.Songs)
                {
                    Console.WriteLine($"  -> {s.SongName} ({s.Genre})");
                }
            }

           
            Console.WriteLine("\n--- Playlist Adı Yenilənir ---");
            playlistService.UpdatePlaylist(1, "Yeni Playlist Adı");

            
            Console.WriteLine("\n--- Playlist Silinir (ID = 1) ---");
            playlistService.DeletePlaylist(1, "Yeni Playlist Adı");

            Console.WriteLine("\n--- program bitdi ---");
        }
    }
}
