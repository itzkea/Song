using Microsoft.AspNetCore.Mvc;
using SongBL;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Reflection.Metadata.Ecma335;

namespace SongAPI.Controllers
{
    [ApiController]
    [Route("api/songs")]
    public class SongController : ControllerBase
    {
        SongGetServices _getServices;
        SongTransactionServices _transactionServices;

        public SongController()
        {
            _getServices = new SongGetServices();
            _transactionServices = new SongTransactionServices();
        }

        [HttpGet]
        public IEnumerable<SongAPI.Song> GetSongs()
        {
            var song = _getServices.GetAllSongs();

            List<SongAPI.Song> cont = new List<SongAPI.Song>();

            foreach (var songs in song)
            {
                cont.Add(new SongAPI.Song { Album = songs.Album, Title = songs.Title });
            }
            return cont;
        }
        [HttpPost]
        public JsonResult AddSong(Song request)
        {
            var result = _transactionServices.CreateSong(request.Album, request.Title);

            return new JsonResult(result);
        }
        [HttpPatch]
        public JsonResult UpdateSong(Song request)
        {
            var result = _transactionServices.UpdateSong(request.Album, request.Title);

            return new JsonResult(result);
        }
        
    }
    

}
        