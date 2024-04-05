using System;
using System.Collections.Generic;
using System.Threading.Channels;
public class SongInfo
{

    public List<Song> songList = new List<Song>();

    public static void DisplaySong(Song song)
    {
        Console.WriteLine("Song Title: " + song.Title );
        Console.WriteLine("Song Album: " + song.Album);
        Console.WriteLine("Song Release Date: " + song.releaseDate);
    }
}

    
