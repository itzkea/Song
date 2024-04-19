using System;
using songDL;
using SongDL;

namespace SongBL
{
    public class SongVerify
    {
        public bool VerifySong(string Album)
        {
            AlbumLibrary songDL = new AlbumLibrary();
            var result = songDL.GetAlbum(Album);

            return result.Album != null ? true : false; 

        }
       
        }

    }