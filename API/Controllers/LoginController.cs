using Negocio;
using Repositorio;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class LoginController : ApiController
    {
        public HttpResponseMessage Logar(Usuario u)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    u = LoginNeg.Logar(u);

                    if (u.Id > 0)
                        return Request.CreateResponse(HttpStatusCode.OK, u);

                    else
                        throw new Exception("Usuário não encontrado");
                }
                else
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Prencha com o seu login e senha");

            }
            catch (Exception exc)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, exc.Message, exc);
            }

        }
    }
}
