using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using songDL;
public class Program
{
    static void Main(string[] args)
    {
        SongLibrary songList = new SongLibrary();

            Console.WriteLine("Welcome to 10 Popular songs of Taylor Swift");
            Console.WriteLine();
            while (true)
            {
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
                        SongInfo.DisplaySong(songList.songList[0]);
                         return;

                    case "2":
                        SongInfo.DisplaySong(songList.songList[1]);
                        return;

                    case "3":
                        SongInfo.DisplaySong(songList.songList[2]);
                        return;

                    case "4":
                        SongInfo.DisplaySong(songList.songList[3]);
                        return;

                    case "5":
                        SongInfo.DisplaySong(songList.songList[4]);
                        return;

                    case "6":
                        SongInfo.DisplaySong(songList.songList[5]);
                        return;
                    
                    case "7":
                        SongInfo.DisplaySong(songList.songList[6]);
                        return;

                    case "8":
                        SongInfo.DisplaySong(songList.songList[7]);
                        return;

                    case "9":
                        SongInfo.DisplaySong(songList.songList[8]);
                        return;

                    case "10":
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









