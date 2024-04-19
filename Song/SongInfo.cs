using System;
using System.Collections.Generic;
using System.Threading.Channels;
public class SongInfo
{

    public List<Song> songList = new List<Song>();

    public static void DisplaySong(Song song)
    {
        Console.WriteLine("Song Album: " + song.Album);
        Console.WriteLine("Song Title: " + song.SongTitle);
        Console.WriteLine("Song Lyrics: " + song.SongLyrics);

    }
}
