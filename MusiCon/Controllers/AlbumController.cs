using Microsoft.AspNetCore.Mvc;
using MusiCon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusiCon.Controllers
{
    [Route("api/album")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        Album albumglobal; //declarei uma variavel do tipo Album em scope global

        [HttpGet]
        public ActionResult<IEnumerable<Album>> Get()
        {
            return new Album[] { albumglobal }; //criei o array de album, listando elemento teste
        }

        [HttpPost]
        public void CreateAlbum([FromBody] Album value)
        {
            albumglobal = value; //salvo o valor recebido no parametro no escopo global (poderia ser um banco)
        }
    }
}
