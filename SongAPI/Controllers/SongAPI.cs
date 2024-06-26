using Microsoft.AspNetCore.Mvc;
using SongBL;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace SongAPI.Controllers
{
    [ApiController]
    [Route("api/songs")]
    public class SongAPI : ControllerBase
    {
        SongGetServices _songGetServices;
        SongTransactionServices _songTransactionServices;

        public SongAPI()
        {
            _songGetServices = new SongGetServices();
            _songTransactionServices = new SongTransactionServices();
        }

        [HttpGet]
        public IEnumerable<Song> GetSongs()
        {
            var songs = _songGetServices.GetAllSongs();

            List<Song> song = new List<Song>();

            foreach (var item in song)
            {
                song.Add(new Song { Album = item.Album, Title = item.Title });

            }
            return song;
        }
        [HttpPost]
        public JsonResult AddSong (Song request)
        {
            var result = _songTransactionServices.CreateSong(request.Album, request.Title);

            return new JsonResult(result);
        }

        [HttpPatch]
        public JsonResult UpdateSong (Song request)
        {
            var result = _songTransactionServices.UpdateSong(request.Album, request.Title);

            return new JsonResult(result);
        }

    } 
    }


   