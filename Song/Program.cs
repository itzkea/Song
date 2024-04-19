using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using songDL;
using SongBL;
using LibraryModel;

public class Program
{
    static void Main(string[] args)
    {
        SongLibrary songList = new SongLibrary();

        Console.Write("Enter Username: ");
        string username = Console.ReadLine();

        Console.Write("Enter Password: ");
        string password = Console.ReadLine();

        UserVerify songDL = new UserVerify();
        bool result = songDL.userverify(username, password);

        if (result)
        {
            Console.WriteLine();
            Console.WriteLine("User Found!");
         
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("No user found!");

            return;

        }

            Console.WriteLine();
            Console.WriteLine("Welcome to Taylor's Songs!");
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Choose a song");
                Console.WriteLine();
                Console.WriteLine("1. Love Story ");
                Console.WriteLine("2. You Belong With Me ");
                Console.WriteLine("3. Fearless ");
                Console.WriteLine("4. All Too Well");
                Console.WriteLine("5. Back To December");
                Console.WriteLine("6. Style");
                Console.WriteLine("7. Lover");
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

                default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid Input!");
                        break;


                }
            }


        }
    }



    









