using Negocio;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    [RoutePrefix("api/Livro")]
    public class LivroController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Listar()
        {
            try
            {
                List<Livro> lista = LivroNeg.Listar();

                return Request.CreateResponse(HttpStatusCode.OK, lista);
            }
            catch (Exception exc)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, exc.Message, exc);
            }
        }

        [HttpPost]
        [Route("Alugar")]
        public HttpResponseMessage Alugar(int idLivro)
        {
            try
            {
                Livro livro = new Livro();
                livro.Id = idLivro;
                var alugado = LivroNeg.Alugar(livro);
                return Request.CreateResponse(HttpStatusCode.OK, alugado);
            }
            catch (Exception exc)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, exc.Message, exc);
            }
        }

        [HttpPost]
        [Route("Liberar")]
        public HttpResponseMessage Liberar(int idLivro)
        {
            try
            {
                Livro livro = new Livro();
                livro.Id = idLivro;
                LivroNeg.Liberar(livro);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception exc)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, exc.Message, exc);
            }
        }

        [HttpPost]
        [Route("Detalhar")]
        public HttpResponseMessage Detalhar(int idLivro)
        {
            try
            {
                Livro livro = new Livro();
                livro.Id = idLivro;
                livro = LivroNeg.Buscar(livro);
                return Request.CreateResponse(HttpStatusCode.OK, livro);
            }
            catch (Exception exc)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, exc.Message, exc);
            }
        }
    }
}
