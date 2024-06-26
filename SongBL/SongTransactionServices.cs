﻿using LibraryModel;
using SongDL;

namespace SongBL
{
    public class SongTransactionServices
    {
        SongValidationServices validationServices = new SongValidationServices();
        SongData songData = new SongData();

        public bool CreateSong(Song song)
        {
            bool result = false;

            if (validationServices.CheckIfSongExists(song.Title))
            {
                result = songData.AddSong(song) > 0;
            }

            return result;
        }

        public bool CreateSong(string Title, string Album)
        {
            Song song = new Song { Title = Title, Album = Album };

            return CreateSong(song);
        }

        public bool UpdateSong(Song song)
        {
            bool result = false;

            if (validationServices.CheckIfSongExists(song.Title))
            {
                result = songData.UpdateSong(song) > 0;
            }

            return result;
        }

        public bool UpdateSong(string Title, string Album)
        {
            Song song = new Song {Title = Title, Album = Album };

            return UpdateSong(song);
        }

        public bool DeleteSong(Song song)
        {
            bool result = false;

            if (validationServices.CheckIfSongExists(song.Title))
            {
                result = songData.DeleteSong(song) > 0;
            }

            return result;
        }
    }
}