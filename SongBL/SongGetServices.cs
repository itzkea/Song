using SongDL;
using LibraryModel;

namespace SongBL
{
    public class SongGetServices
    {
        public List<Song> GetAllSongs()
        {
            SongData songData = new SongData();

            return songData.GetSongs();

        }

        public Song GetSongs(string Title, string Album)
        {
            Song foundSong = new Song();

            foreach (var song in GetAllSongs())
            {
                if (song.Title == Title && song.Album == Album)
                {
                    foundSong= song;
                }
            }

            return foundSong;
        }

        public Song GetSong(string Title)
        {
            Song foundSong= new Song();

            foreach (var song in GetAllSongs())
            {
                if (song.Title == Title)
                {
                    foundSong= song;
                }
            }

            return foundSong;
        }
    }
}