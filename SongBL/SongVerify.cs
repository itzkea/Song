using System;
using songDL;

namespace SongBL
{
    public class SongVerify
    {
        public bool VerifySong(string title)
        {
            SongLibrary songDL = new SongLibrary();
            var result = songDL.GetSong(title);

            return result.Title != null ? true : false; 

        }
       
        }

    }