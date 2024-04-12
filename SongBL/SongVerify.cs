using System;
using songDL;

namespace SongBL
{
    public class SongVerify
    {
        public bool VerifySong(String title, string album, string releaseDate)
        {
            SongLibrary songDL = new SongLibrary();
            var result = songDL.GetSong(title,album,releaseDate);

            return result.Title != null ? true : false && result.Album != null ? true : false && result.ReleaseDate != null ? true : false;

        }

    }
}
