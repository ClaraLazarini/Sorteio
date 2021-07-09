using System;
using NUnit.Framework;

namespace Sorteio.Familia
{
    [TestFixture]
    public class PessoaTeste
    {
        [Test]
        public void Deve_adicionar_uma_pessoa_como_pretendente()
        {
            var nome = "Joao";
            var tipo = Tipo.Pretendente;
            var dataDeNascimento = DateTime.Today;

            var pessoa = new Pessoa(nome, tipo, dataDeNascimento, 1500);

            Assert.AreEqual(nome, pessoa.Nome);
            Assert.AreEqual(tipo, pessoa.Tipo);
            Assert.AreEqual(dataDeNascimento, pessoa.DataDeNascimento);
        }

        [Test]
        public void Deve_adicionar_uma_pessoa_como_filho()
        {
            var nome = "felipe";
            var tipo = Tipo.Filho;
            var dataDeNascimento = new DateTime(1999, 06,03);

            var pessoa = new Pessoa(nome, tipo, dataDeNascimento, 1500);

            Assert.AreEqual("felipe", pessoa.Nome);
            Assert.AreEqual(Tipo.Filho, pessoa.Tipo);
        }

        [Test]
        public void Deve_calcular_uma_idade_uma_pessoa_quando()
        {
            var idade = 25;
            var dataDeNascimento = new DateTime(1995,10,31);
            var pessoa = new Pessoa("maria", Tipo.Pretendente, dataDeNascimento, 1500);

            var idadeExperada = pessoa.ObterCalculoIdade();

            Assert.AreEqual(idade, idadeExperada);
        }
    }
}
