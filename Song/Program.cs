using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using songDL;
using SongBL;
using SongDL;
public class Program
{
    static void Main(string[] args)
    {
        SongLibrary songList = new SongLibrary();

        Console.Write("Enter Album: ");
        string album = Console.ReadLine();

        SongVerify songDL = new SongVerify();
        bool result = songDL.VerifySong(album);

        if (result)
        {
            Console.WriteLine();
            Console.WriteLine("Album Found!");
         
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("No album found!");

            return;

        }

            Console.WriteLine();
            Console.WriteLine("Welcome!");
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Choose song from album fearless:");
                Console.WriteLine();
                Console.WriteLine("1. Fearless");
                Console.WriteLine("2. Lover");
                Console.WriteLine("3. Red");
                Console.WriteLine();
         

            Console.Write("Your choice: ");

               string choices = Console.ReadLine();

                switch (choices)
                {
                    case "1":
                        Console.WriteLine();
                        SongInfo.DisplaySong(songList.songList[0]);
                        return;

                    case "2":
                        Console.WriteLine();
                        SongInfo.DisplaySong(songList.songList[1]);
                        return;

                    case "3":
                        Console.WriteLine();
                        SongInfo.DisplaySong(songList.songList[2]);
                        return;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid Input");
                        break;


                }
            }


        }
    }



    









