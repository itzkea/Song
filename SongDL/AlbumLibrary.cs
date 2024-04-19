using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongDL
{
    public class AlbumLibrary
    {
        public List<Song> AlbumList = new List<Song>();

        public AlbumLibrary() 
        { 

            Song AlbumOne = new Song();
            AlbumOne.Album = "Fearless";
            AlbumList.Add(AlbumOne);

            Song AlbumTwo = new Song();
            AlbumTwo.Album = "Lover";
            AlbumList.Add(AlbumTwo);

            Song AlbumThree = new Song();
            AlbumThree.Album = "Red";
            AlbumList.Add(AlbumThree);

        }
        public Song GetAlbum(string album)
        {
            Song foundSong = new Song();

            foreach (var song in AlbumList)
            {
                if (album == song.Album)
                {
                    foundSong = song;
                }
            }

            return foundSong;


        }
    }
}
