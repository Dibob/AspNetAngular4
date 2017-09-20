using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using ProductsApp.Models;

namespace ProductsApp.Controllers
{
    public class FotosController : ApiController
    {
        Foto[] fotos = new Foto[]
         {
            new Foto { Id = 1, Titulo = "Tomato Soup", Url = "Groceries", Descricao = 1 },
            new Foto { Id = 2, Titulo = "Yo-yo", Url = "Toys", Descricao = 3.75M },
            new Foto { Id = 3, Titulo = "Hammer", Url = "Hardware", Descricao = 16.99M }
         };




        public IEnumerable<Foto> GetAllFotos()
        {
            return fotos;
        }


        public IHttpActionResult GetFoto(int id)
        {
            var foto = fotos.FirstOrDefault((p) => p.Id == id);
            if (foto == null)
            {
                return NotFound();
            }
            return Ok(foto);
        }
    }
}
