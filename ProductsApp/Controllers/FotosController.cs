

using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using ProductsApp.Models;

namespace ProductsApp.Controllers
{
    
    public class FotosController : ApiController
    {
        private static IList<Foto>  listaDeFotos = new List<Foto>
        {
            new Foto { Id = 1, Titulo = "Tomato Soup", Url = "Groceries", Descricao = 1 },
            new Foto { Id = 2, Titulo = "Yo-yo", Url = "Toys", Descricao = 3.75M },
            new Foto { Id = 3, Titulo = "Hammer", Url = "Hardware", Descricao = 16.99M }
		};
        int count = 3;

        [HttpGet]
		public IEnumerable<Foto> TrazerFotos()
        {
            return listaDeFotos;
        }


        [HttpGet]
        public IHttpActionResult ObterFoto(int id)
        {
            var foto = listaDeFotos.FirstOrDefault((p) => p.Id == id);
            if (foto == null)
            {
                return NotFound();
            }
            return Ok(foto);
        }



        /*
        public IHttpActionResult TrazerResultadosPaginados(int offset, int limit)
        {
            
        }*/


        [HttpPost]
        public IHttpActionResult Cadastrar([FromBody]Foto foto)
        {
            count++;
            foto.Id = count;
            listaDeFotos.Add(foto);
            return Ok();
		}


        [HttpDelete]
		public IHttpActionResult DeletarFotos(int id)
        {
            listaDeFotos.Remove(listaDeFotos.First(p=>p.Id == id));
            return Ok();
        }




		[HttpPut]
        public IHttpActionResult AtualizarFotos([FromBody]Foto foto)
        {
            Foto fotoAtualizar = listaDeFotos.First(p => p.Id == foto.Id);

            if (fotoAtualizar != null)
            {
                listaDeFotos.Where(p => p.Id == foto.Id).ToList().ForEach(s => s = foto);
                  return Ok();
            }
            return NotFound();
        }
	}
}
