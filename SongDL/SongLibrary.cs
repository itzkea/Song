using LibraryModel;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Xml;

namespace songDL;

public class SongLibrary
{
    public List<Song> songList = new List<Song>();

    public SongLibrary()
    {
        Song songOne = new Song();
        songOne.Album = "Fearless";
        songOne.Title = "Love Story";
        songOne.releaseDate = "November 11, 2008";
        songOne.Lyrics = "Romeo, take me somewhere we can be alone \r\n " +
                         "I'll be waiting, \r\n" +
                         "all there's left to do is run \r\n " +
                         "You'll be the prince and I'll be the princess \r\n " +
                         "It's a love story, baby, just say,Yes";
        songList.Add(songOne);

        Song songTwo = new Song();
        songTwo.Album = "Fearless";
        songTwo.Title = "You Belong With Me";
        songTwo.releaseDate = "October 27, 2014";
        songTwo.Lyrics = "If you could see that I'm the one who understands you \r\n  " +
                         "Been here all along, so why can't you see?\" \r\n  " +
                         "You belong with me, you belong with me\";";
        songList.Add(songTwo);

        Song songThree = new Song();
        songThree.Album = "Fearless";
        songThree.Title = "Fearless";
        songThree.releaseDate = "October 27, 2014";
        songThree.Lyrics = "And I don't know how it gets better than this\" \r\n    " +
                           "You take my hand and drag me headfirst, fearless\" \r\n  " +
                           "And I don't know why, but with you, I'd danceIn a\" \r\n   " +
                           "storm, in my best dress, fearless";
        songList.Add(songThree);

        Song songFour = new Song();
        songFour.Album = "Red";
        songFour.Title = "All too well";
        songFour.releaseDate = "October 22, 2012";
        songFour.Lyrics = "'Cause there we are again on that little town street\r\n" +
                          "You almost ran the red 'cause you were lookin' over at me\r\n" +
                          "Wind in my hair, I was there\r\n" +
                          "I remember it all too well";
        songList.Add(songFour);

        Song songFive = new Song();
        songFive.Album = "Speak Now";
        songFive.Title = "Back to december";
        songFive.releaseDate = "October 25, 2010";
        songFive.Lyrics = "So, this is me swallowing my pride\r\n" +
                          "Standin' in front of you sayin', \"I'm sorry for that night\"\r\n" +
                          "And I go back to December all the time\r\n" +
                          "It turns out freedom ain't nothing but missin' you\r\n" +
                          "Wishin' I'd realized what I had when you were mine\r\n" +
                          "I go back to December, turn around and make it alright\r\n" +
                          "I go back to December all the time\r\n";
        songList.Add(songFive);

        Song songSix = new Song();
        songSix.Album = "1989";
        songSix.Title = "Style";
        songSix.releaseDate = "October 27, 2014";
        songSix.Lyrics = "You got that James Dean daydream look in your eye\r\n" +
                         "And I got that red lip classic thing that you like\r\n" +
                         "And when we go crashing down, we come back every time\r\n" +
                         "'Cause we never go out of style, we never go out of style\r\n" +
                         "You got that long hair, slicked back, white T-shirt\r\n" +
                         "And I got that good girl faith and a tight little skirt\r\n" +
                         "And when we go crashing down, we come back every time\r\n" +
                         "'Cause we never go out of style, we never go out of style";
        songList.Add(songSix);

        Song songSeven = new Song();
        songSeven.Album = "Lover";
        songSeven.Title = "Lover";
        songSeven.releaseDate = "August 23, 2019";
        songSeven.Lyrics = "Can I go where you go?\r\n" +
                           "Can we always be this close?\r\n" +
                           "Forever and ever, ah\r\n" +
                           "Take me out and take me home\r\n" +
                           "You're my, my, my, my lover";
        songList.Add(songSeven);

    }
    
}

    
















