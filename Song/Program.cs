using LibraryModel;
using SongBL;
using SongDL;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SongGetServices getServices = new SongGetServices();

            var song = getServices.GetAllSongs();

            foreach (var item in song)
            {
                Console.WriteLine(item.Album);
                Console.WriteLine(item.Title);
                Console.WriteLine(); 

            }

        }
    }
}