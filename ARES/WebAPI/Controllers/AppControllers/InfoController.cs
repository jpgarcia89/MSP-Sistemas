using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;
namespace WebAPI.Controllers.AppControllers
{
    public class InfoController : ApiController
    {
        // GET: api/Info
        public IHttpActionResult Get()
        {
            List<Info> datos = new List<Info>();

            var item = new Info {
                ID=1,
                titulo= "Y ella führer",
                contenido="Mandale saludos de mi parta a ella en tanga",
                ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg",
            };
            datos.Add(item);

            item = new Info
            {
                ID = 2,
                titulo = "Titulo 2",
                contenido = "Aca estoy mandando fruta q supuestamente es el contenido de la info!!",
                ImgUrl = "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg",
            };
            datos.Add(item);

            item = new Info
            {
                ID = 3,
                titulo = "Titulo 3",
                contenido = "Aca estoy mandando fruta q supuestamente es el contenido de la info!!",
                ImgUrl = "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg",
            };
            datos.Add(item);

            item = new Info
            {
                ID = 4,
                titulo = "Titulo 4",
                contenido = "Aca estoy mandando fruta q supuestamente es el contenido de la info!!",
                ImgUrl = "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg",
            };
            datos.Add(item);

            return Json(datos);
        }

        // GET: api/Info/5
        public IHttpActionResult Get(int id)
        {
            List<Info> datos = new List<Info>();

            var item = new Info
            {
                ID = 1,
                titulo = "Y ella führer",
                contenido = "Mandale saludos de mi parta a ella en tanga",
                ImgUrl = "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg",
            };
            datos.Add(item);

            item = new Info
            {
                ID = 2,
                titulo = "Titulo 2",
                contenido = "Aca estoy mandando fruta q supuestamente es el contenido de la info!!",
                ImgUrl = "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg",
            };
            datos.Add(item);

            item = new Info
            {
                ID = 3,
                titulo = "Titulo 3",
                contenido = "Aca estoy mandando fruta q supuestamente es el contenido de la info!!",
                ImgUrl = "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg",
            };
            datos.Add(item);

            item = new Info
            {
                ID = 4,
                titulo = "Titulo 4",
                contenido = "Aca estoy mandando fruta q supuestamente es el contenido de la info!!",
                ImgUrl = "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg",
            };
            datos.Add(item);

            return Json(datos.Where(r=>r.ID == id));
        }

        // POST: api/Info
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Info/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Info/5
        public void Delete(int id)
        {
        }
    }
}
