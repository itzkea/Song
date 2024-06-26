namespace SongBL;

public class SongValidationServices
{

    SongGetServices getservices = new SongGetServices();

    public bool CheckIfSongExists(string Title)
    {
        bool result = getservices.GetSong(Title) != null;
        return result;
    }

    public bool CheckIfSongExists(string Title, string Album)
    {
        bool result = getservices.GetSongs(Title, Album) != null;
        return result;
    }

}
