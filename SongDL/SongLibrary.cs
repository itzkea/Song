using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace songDL;

public class SongLibrary
{
    public List<Song> songList = new List<Song>();

    public SongLibrary()
    {
        Song songOne = new Song();
        songOne.Title = "Style";
        songOne.Album = "1989";
        songOne.ReleaseDate = "October 27, 2014";
        songList.Add(songOne);

        Song songTwo = new Song();
        songTwo.Title = "All too well";
        songTwo.Album = "Red";
        songTwo.ReleaseDate = "October 22, 2012";
        songList.Add(songTwo);

        Song songThree = new Song();
        songThree.Title = "Love Story";
        songThree.Album = "Fearless";
        songThree.ReleaseDate = "November 11, 2008";
        songList.Add(songThree);

        Song songFour = new Song();
        songFour.Title = "You Belong With Me";
        songFour.Album = "Fearless";
        songFour.ReleaseDate = "October 27, 2014";
        songList.Add(songFour);

        Song songFive = new Song();
        songFive.Title = "Cruel Summer";
        songFive.Album = "Lover";
        songFive.ReleaseDate = "August 23, 2019";
        songList.Add(songFive);

        Song songSix = new Song();
        songSix.Title = "Shake it off";
        songSix.Album = "1989";
        songSix.ReleaseDate = "October 27, 2014";
        songList.Add(songSix);

        Song songSeven = new Song();
        songSeven.Title = "We Are Never Ever Getting Back Together";
        songSeven.Album = "Red";
        songSeven.ReleaseDate = "October 22, 2012";
        songList.Add(songSeven);

        Song songEight = new Song();
        songEight.Title = "Anti-Hero";
        songEight.Album = "Midnights";
        songEight.ReleaseDate = "October 21, 2022";
        songList.Add(songEight);

        Song songNine = new Song();
        songNine.Title = "22";
        songNine.Album = "Red";
        songNine.ReleaseDate = "October 22, 2012";
        songList.Add(songNine);

        Song songTen = new Song();
        songTen.Title = "Bact to december";
        songTen.Album = "Speak Now";
        songTen.ReleaseDate = "October 25, 2010";
        songList.Add(songTen);


    }

    public Song GetSong(string title, string album, string releaseDate)
    {
        Song foundSong = new Song();

        foreach (var song in songList)
        {
            if (title == song.Title && album == song.Album && releaseDate == song.ReleaseDate) 
            {
                foundSong = song;
            }
        }

        return foundSong;

    }

}
















