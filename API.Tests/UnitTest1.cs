using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio;
using Repositorio;

namespace API.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AlugarLivro_JaAlugado()
        {

            Livro livro = new Livro();
            livro.Titulo = "Livro Me Poupe!";
            livro.Autor = "Nathalia Arcuri";
            livro.Alugado = true;
            using (CadastroEntities dc = new CadastroEntities())
            {
                livro = dc.Livro.Add(livro);
                dc.SaveChanges();
            }

            // Act
            bool alugado = LivroNeg.Alugar(livro);

            // Assert
            Assert.IsFalse(alugado);
        }

        [TestMethod]
        public void AlugarLivro_Sucesso()
        {

            Livro livro = new Livro();
            livro.Titulo = "Livro Me Poupe!";
            livro.Autor = "Nathalia Arcuri";
            livro.Alugado = false;
            using (CadastroEntities dc = new CadastroEntities())
            {
                livro = dc.Livro.Add(livro);
                dc.SaveChanges();
            }

            // Act
            bool alugado = LivroNeg.Alugar(livro);

            // Assert
            Assert.IsTrue(alugado);
        }

        [TestMethod]
        public void LiberarLivro_Sucesso()
        {

            Livro livro = new Livro();
            livro.Titulo = "Quem quer ser um milionário?";
            livro.Autor = "Vikas Swarup";
            livro.Alugado = true;
            using (CadastroEntities dc = new CadastroEntities())
            {
                livro = dc.Livro.Add(livro);
                dc.SaveChanges();
            }

            // Act
            var alugado = LivroNeg.Liberar(livro);

            // Assert
            Assert.IsTrue(alugado);
        }

        [TestMethod]
        public void BuscarLivro_IdLivroValido_DeveRetornarLivro()
        {

            Livro livro = new Livro();
            livro.Id = 2;

            // Act
            Livro livroRet = LivroNeg.Buscar(livro);

            // Assert
            Assert.IsNotNull(livroRet);
        }

        [TestMethod]
        public void BuscarLivro_IdLivroInvalido_DeveRetornarNull()
        {

            Livro livro = new Livro();
            livro.Id = 9997;

            // Act
            Livro livroRet = LivroNeg.Buscar(livro);

            // Assert
            Assert.IsNull(livroRet);
        }
    }
}
