using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Sorteio.Familia
{
    [TestFixture]
    public  class FamiliaTeste
    {
        [Test]
        public void Deve_criar_uma_familia()
        {
            var pessoa1 = new Pessoa("maria", Tipo.Pretendente, DateTime.Now, 1500);
            var pessoa2 = new Pessoa("joao", Tipo.Filho, DateTime.Today, 1500);
            var familia = new Familia(new List<Pessoa>{pessoa1, pessoa2}, Status.CadastroValido);

            var familiaExperada = familia;

            Assert.AreEqual(familiaExperada, familia);
        }

        [Test]
        public void Deve_calcular_a_renda_de_uma_familia()
        {
            var pessoa1 = new Pessoa("maria", Tipo.Pretendente, DateTime.Now, 1500);
            var pessoa2 = new Pessoa("joao", Tipo.Filho, DateTime.Today, 1500m);
            var familia = new Familia(new List<Pessoa> { pessoa1, pessoa2 }, Status.CadastroValido);

            var rendaTotalDaFamilia = familia.ObterValorTotalDaRenda();

            Assert.AreEqual(3000m, rendaTotalDaFamilia);
        }

        [Test]
        public void Deve_retornar_a_idade_do_pretendente()
        {
            var pessoa1 = new Pessoa("maria", Tipo.Pretendente, new DateTime(1978, 03, 02), 1500);
            var pessoa2 = new Pessoa("joao", Tipo.Filho, DateTime.Today, 1500m);
            var familia = new Familia(new List<Pessoa> { pessoa1, pessoa2 }, Status.CadastroValido);

            var idadeDoPretendente = familia.ObterIdadeDoPretendente();

            Assert.AreEqual(43, idadeDoPretendente);
        }

        [Test]
        public void Deve_retornar_a_quantidade_de_integrantes_na_familia()
        {
            var pessoa = new Pessoa("Jose", Tipo.Pretendente, DateTime.Today, 1500m);
            var pessoa1 = new Pessoa("maria", Tipo.Mulher, DateTime.Today, 1500m);
            var pessoa2 = new Pessoa("joao", Tipo.Filho, DateTime.Today, 1500m);
            var familia = new Familia(new List<Pessoa> {pessoa, pessoa1, pessoa2}, Status.CadastroIncompleto);

            var quantidadeDeIntegrantesNaFamilia = familia.ObterQuantidadeDeIntegrantes();

            Assert.AreEqual(3, quantidadeDeIntegrantesNaFamilia);
        }

        [Test]
        public void deve_quantidade_de_integrantes_de_uma_familia_menor_de_dezoito_anos()
        {

            var pessoa = new Pessoa("Jose", Tipo.Pretendente, DateTime.MinValue, 1500m);
            var pessoa1 = new Pessoa("maria", Tipo.Filho, DateTime.Today, 1500m);
            var pessoa2 = new Pessoa("joao", Tipo.Filho, DateTime.Today, 1500m);
            var familia = new Familia(new List<Pessoa> { pessoa, pessoa1, pessoa2 }, Status.CadastroIncompleto);

            var quantidadeDeIntegrantes = familia.ObterQuantidadeDeIntegrantesMenorDeIdade();

            Assert.AreEqual(2, quantidadeDeIntegrantes);
        }
    }
}
