using System;
using System.Collections.Generic;
using NUnit.Framework;
using Sorteio.Familia;


namespace Sorteio.Selecao
{
    [TestFixture]
    public class PontuacaoTeste
    {
        [Test]
        public void deve_calcular_a_pontuacao_por_renda_da_familia()
        {
            
            var pessoa1 = new Pessoa("maria", Tipo.Pretendente, new DateTime(1987, 06, 15), 100);
            var pessoa = new Pessoa("jose", Tipo.Filho, new DateTime(2000, 11, 02), 200);
            var familia = new Familia.Familia(new List<Pessoa> { pessoa1, pessoa }, Status.CadastroValido);
            var pontuacao = new Pontuacao(familia);

            var pontuacaoExperada = pontuacao.ObterPorRendaDaFamilia();

            Assert.AreEqual(5, pontuacaoExperada);
        }

        [Test]
        public void deve_calcular_a_pontuacao_pela_idade_do_pretendente()
        {
            var pessoa1 = new Pessoa("maria", Tipo.Pretendente, new DateTime(1978, 03, 02), 1500);
            var pessoa2 = new Pessoa("joao", Tipo.Filho, DateTime.Today, 1500m);
            var familia = new Familia.Familia(new List<Pessoa> { pessoa1, pessoa2 }, Status.CadastroValido);
            var pontuacao = new Pontuacao(familia);

            var pontuacaExperada = pontuacao.ObterPorIdadeDoPretendente();

            Assert.AreEqual(2, pontuacaExperada);
        }

        [Test]
        public void deve_calcular_a_pontuacao_de_acordo_com_os_dependentes()
        {
            var pessoa = new Pessoa("Jose", Tipo.Pretendente, DateTime.MinValue, 1500m);
            var pessoa1 = new Pessoa("maria", Tipo.Filho, DateTime.Today, 1500m);
            var pessoa2 = new Pessoa("joao", Tipo.Filho, DateTime.Today, 0);
            var familia = new Familia.Familia(new List<Pessoa> { pessoa, pessoa1, pessoa2 }, Status.CadastroIncompleto);
            var pontuacao = new Pontuacao(familia);

            var pontuacaoExperada = pontuacao.ObterPorQuantidadeDeDependentes();

            Assert.AreEqual(2, pontuacaoExperada);
        }

        [Test]
        public void deve_calcular_a_pontuacao_total_obtida_pela_familia()
        {
            var pessoa = new Pessoa("Jose", Tipo.Pretendente, DateTime.MinValue, 1500m);
            var pessoa1 = new Pessoa("maria", Tipo.Filho, DateTime.Today, 1500m);
            var pessoa2 = new Pessoa("joao", Tipo.Filho, DateTime.Today, 0);
            var familia = new Familia.Familia(new List<Pessoa> { pessoa, pessoa1, pessoa2 }, Status.CadastroIncompleto);
            var pontuacao = new Pontuacao(familia);

            var pontuacaoExperada = pontuacao.ObterPontuacaoTotal();
            Assert.AreEqual(5, pontuacaoExperada);
        }
    }
}
