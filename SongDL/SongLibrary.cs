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
        songOne.SongTitle = "Fearless";
        songOne.SongLyrics = "And I don't know how it gets better than this" '\n' +
                             "You take my hand and drag me headfirst, fearless" +
                             "And I don't know why, but with you, I'd danceIn a" + 
                             "storm, in my best dress, fеarless";

        songOne.SongTitle = "Love Story";
        songOne.SongTitle = "You Belong With Me";
        songList.Add(songOne);

        Song songTwo = new Song();
        songTwo.SongTitle = "Cruel Summer";
        songTwo.SongTitle = "Lover";
        songTwo.SongTitle = "The Archer";
        songList.Add(songTwo);

        Song songThree = new Song();
        songThree.SongTitle = "All Too Well";
        songThree.SongTitle = "22";
        songThree.SongTitle = "Red";
        songList.Add(songThree);

    }

    

    public void SongLyrics()
    {
        List<Song> FearlessOneLyrics = new List<Song>();

        Song songOneLyrics = new Song();
        songOneLyrics.SongTitle = "Fearless";
        songOneLyrics.SongLyrics = "And I don't know how it gets better than this" +
                                   "You take my hand and drag me headfirst, fearless" +
                                   "And I don't know why, but with you, I'd danceIn a" +
                                   "storm, in my best dress, fеarless";
        FearlessOneLyrics.Add(songOneLyrics);

        Song songTwoLyrics = new Song();
        songOneLyrics.SongTitle = "Love Story";
        songOneLyrics.SongLyrics = "Romeo, take me somewhere we can be alone" +
                                   "I'll be waiting, all there's left to do is run" +
                                   "You'll be the prince and I'll be the princess" +
                                   "It's a love story, baby, just say,Yes";
        FearlessOneLyrics.Add(songTwoLyrics);

        Song songThreeLyrics = new Song();
        songOneLyrics.SongTitle = "You Belong With Me";
        songOneLyrics.SongLyrics = "If you could see that I'm the one who understands you" +
                                   "Been here all along, so why can't you see?" +
                                   "You belong with me, you belong with me";
        FearlessOneLyrics.Add(songThreeLyrics);


        List<Song> LoverOneLyrics = new List<Song>();

        Song songFourLyrics = new Song();
        songOneLyrics.SongTitle = "Cruel Summer";
        songOneLyrics.SongLyrics = "And it's new, the shape of your body" +
                                   "It's blue, the feeling I've got" +
                                   "And it's ooh, woah-oh" +
                                   "It's a cruel summer" +
                                   "It's cool, that's what I tell 'em" +
                                   "No rules in breakable heaven" +
                                   "But ooh, woah-oh" +
                                   "It's a cruel summer with you";
        LoverOneLyrics.Add(songFourLyrics);

        Song songFiveLyrics = new Song();
        songOneLyrics.SongTitle = "Lover";
        songOneLyrics.SongLyrics = "Can I go where you go?" +
                                   "Can we always be this close?" +
                                   "Forever and ever, ah" +
                                   "Take me out and take me home" +
                                   "You're my, my, my, my lover";
        LoverOneLyrics.Add(songFiveLyrics);

        Song songSixLyrics = new Song();
        songOneLyrics.SongTitle = "The Archer";
        songOneLyrics.SongLyrics = "I've been the archer, I've been the prey" +
                                   "Who could ever leave me, darling" +
                                   "But who could stay?";
        LoverOneLyrics.Add(songSixLyrics);

        List<Song> RedOneLyrics = new List<Song>();

        Song songSevenLyrics = new Song();
        songOneLyrics.SongTitle = "All Too Well";
        songOneLyrics.SongLyrics = "'Cause there we are again on that little town street" +
                                   "You almost ran the red 'cause you were lookin' over at me" +
                                   "Wind in my hair, I was there" +
                                   "I remember it all too well";
        RedOneLyrics.Add(songSevenLyrics);

        Song songEightLyrics = new Song();
        songOneLyrics.SongTitle = "22";
        songOneLyrics.SongLyrics = "I don't know about you" +
                                   "But I'm feeling twenty-two" +
                                   "Everything will be alright if" +
                                   "You keep me next to you" +
                                   "You don't know about me" +
                                   "But I'll bet you want to" +
                                   "Everything will be alright if" +
                                   "We just keep dancing like we're" +
                                   "Twenty-two, twenty-two";
        RedOneLyrics.Add(songEightLyrics);

        Song songNineLyrics = new Song();
        songOneLyrics.SongTitle = "Red";
        songOneLyrics.SongLyrics = "Losing him was blue like I'd never known" +
                                   "Missing him was dark gray, all alone (Woah)" +
                                   "Forgetting him was like tryin' to know somebody you never met" +
                                   "But loving him was red (Red, red)" +
                                   "(Red, red)" +
                                   "But loving him was red (Red, red)" +
                                   "(Red, red)";
        RedOneLyrics.Add(songNineLyrics);


    }

    public Song GetSong(string album)
    {
        Song foundSong = new Song();

        foreach (var song in songList)
        {
            if (album == song.Album)
            {
                foundSong = song;
            }
        }

        return foundSong;


    }

}
















