using Repositorio;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Migrations;
using System.Linq;


namespace Negocio
{
    public class LivroNeg
    {
        public static List<Livro> Listar()
        {
            List<Livro> livros = new List<Livro>();

            using (CadastroEntities dc = new CadastroEntities())
            {
                livros = dc.Livro.ToList();
            }

            return livros;
        }

        public static Livro Buscar(Livro livro)
        {

            Livro livroAux = new Livro();
            using (CadastroEntities dc = new CadastroEntities())
            {
                livroAux = dc.Livro.Where(a => a.Id.Equals(livro.Id)).FirstOrDefault();
            }
            return livroAux;


        }


        public static bool Alugar(Livro livro)
        {
            Livro livroSeraAlugado = new Livro();
            using (CadastroEntities dc = new CadastroEntities())
            {

                livroSeraAlugado = dc.Livro.Where(a => a.Id.Equals(livro.Id)).FirstOrDefault();
                if (livroSeraAlugado != null && !livroSeraAlugado.Alugado)
                {
                    livroSeraAlugado.Alugado = true;
                    dc.Livro.AddOrUpdate(livroSeraAlugado);
                    dc.SaveChanges();

                    return true;

                }

                return false;
            }
        }
        public static bool Liberar(Livro livro)
        {
            Livro livroSeraAlugado = new Livro();
            using (CadastroEntities dc = new CadastroEntities())
            {
                livroSeraAlugado = dc.Livro.Where(a => a.Id.Equals(livro.Id)).FirstOrDefault();
                livroSeraAlugado.Alugado = false;
                dc.Livro.AddOrUpdate(livroSeraAlugado);
                dc.SaveChanges();

                return true;
            }

            return false;
        }

    }
}
