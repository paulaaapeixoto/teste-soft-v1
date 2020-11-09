using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class LoginNeg
    {

        public static Usuario Logar(Usuario u)
        {
            Usuario v = new Usuario();
            //TODO:MELHORAR
            using (CadastroEntities dc = new CadastroEntities())
            {
                v = dc.Usuario.Where(a => a.NomeUsuario.Equals(u.NomeUsuario) && a.Senha.Equals(u.Senha)).FirstOrDefault();
            }

            return v;
        }
    }
}
