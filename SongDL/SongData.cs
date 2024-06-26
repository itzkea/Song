using LibraryModel;

namespace SongDL
{
    public class SongData
    {
        List<Song> song;
        SqlDataBase sqlData;
        public SongData()
        {
            song = new List<Song>();
            sqlData = new SqlDataBase();


        }

        public List<Song> GetSongs()
        {
            song = sqlData.GetSongs();
            return song;
        }

        public int AddSong(Song song)
        {
            return sqlData.AddSong(song.Album, song.Title);
        }

        public int UpdateSong(Song song)
        {
            return sqlData.UpdateSong(song.Title, song.Album);
        }

        public int DeleteSong(Song song)
        {
            return sqlData.DeleteSong(song.Title, song.Album);
        }
    }
}
