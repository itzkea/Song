using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using songDL;
using SongBL;
public class Program
{
    static void Main(string[] args)
    {
        SongLibrary songList = new SongLibrary();

        Console.WriteLine("Enter a Taylor song that you think is included in her top 10 most popular songs");
        Console.WriteLine();
        string title = Console.ReadLine();

        SongVerify songDL = new SongVerify();
        bool result = songDL.VerifySong(title);

        if (result)
        {
            Console.WriteLine();
            Console.WriteLine("Song Found!!!");
         
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Not included in the top 10");

            return;

        }

            Console.WriteLine();
            Console.WriteLine("Welcome to 10 Popular songs of Taylor Swift");
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Choose Song of Taylor Swift:");
                Console.WriteLine();
                Console.WriteLine("1. Style");
                Console.WriteLine("2. All too well");
                Console.WriteLine("3. Love Story");
                Console.WriteLine("4, You Belong With Me");
                Console.WriteLine("5. Cruel Summer");
                Console.WriteLine("6. Shake it off");
                Console.WriteLine("7. We Are Never Ever Getting Back Together");
                Console.WriteLine("8. Anti-Hero");
                Console.WriteLine("9. 22");
                Console.WriteLine("10. Back to december");
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

                    case "4":
                        Console.WriteLine();
                        SongInfo.DisplaySong(songList.songList[3]);
                        return;

                    case "5":
                        Console.WriteLine();
                        SongInfo.DisplaySong(songList.songList[4]);
                        return;

                    case "6":
                        Console.WriteLine();
                        SongInfo.DisplaySong(songList.songList[5]);
                        return;

                    case "7":
                        Console.WriteLine();
                        SongInfo.DisplaySong(songList.songList[6]);
                        return;

                    case "8":
                        Console.WriteLine();
                        SongInfo.DisplaySong(songList.songList[7]);
                        return;

                    case "9":
                        Console.WriteLine();
                        SongInfo.DisplaySong(songList.songList[8]);
                        return;

                    case "10":
                        Console.WriteLine();
                        SongInfo.DisplaySong(songList.songList[9]);
                        return;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid Input");
                        break;


                }
            }


        }
    }



    









