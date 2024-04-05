using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

    public class SongLibrary
    {
        public List<Song> songList = new List<Song>();

        public SongLibrary()
        {
            Song songOne = new Song();
            songOne.Title = "Style";
            songOne.Album = "1989";
            songOne.releaseDate = "October 27, 2014";
            songList.Add(songOne);

            Song songTwo = new Song();
            songTwo.Title = "All too well";
            songTwo.Album = "Red";
            songTwo.releaseDate = "October 22, 2012";
            songList.Add(songTwo);

            Song songThree = new Song();
            songThree.Title = "Love Story";
            songThree.Album = "Fearless";
            songThree.releaseDate = "November 11, 2008";
            songList.Add(songThree);

            Song songFour = new Song();
            songFour.Title = "You Belong With Me";
            songFour.Album = "Fearless";
            songFour.releaseDate = "October 27, 2014";
            songList.Add(songFour);

            Song songFive = new Song();
            songFive.Title = "Cruel Summer";
            songFive.Album = "Lover";
            songFive.releaseDate = "August 23, 2019";
            songList.Add(songFive);

            Song songSix = new Song();
            songSix.Title = "Shake it off";
            songSix.Album = "1989";
            songSix.releaseDate = "October 27, 2014";
            songList.Add(songSix);

            Song songSeven = new Song();
            songSeven.Title = "We Are Never Ever Getting Back Together";
            songSeven.Album = "Red";
            songSeven.releaseDate = "October 22, 2012";
            songList.Add(songSeven);

            Song songEight = new Song();
            songEight.Title = "Anti-Hero";
            songEight.Album = "Midnights";
            songEight.releaseDate = "October 21, 2022";
            songList.Add(songEight);

            Song songNine = new Song();
            songNine.Title = "22";
            songNine.Album = "Red";
            songNine.releaseDate = "October 22, 2012";
            songList.Add(songNine);

            Song songTen = new Song();
            songTen.Title = "Bact to december";
            songTen.Album = "Speak Now";
            songTen.releaseDate = "October 25, 2010";
            songList.Add(songTen);


        }


    }








