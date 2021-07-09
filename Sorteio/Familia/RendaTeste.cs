using System;
using NUnit.Framework;

namespace Sorteio.Familia
{
    [TestFixture]
    public class RendaTeste
    {
        private string nome;
        private Tipo tipo;
        private DateTime dataDeNascimento;
        private decimal rendaDaPessoa;

        [SetUp]
        public void SetUp()
        {
            nome = "maria";
            tipo = Tipo.Pretendente;
            dataDeNascimento = new DateTime(1987, 03, 24);
            rendaDaPessoa = 1500;
        }

        [Test]
        public void deve_atribuir_uma_renda()
        {
            
            var pessoa = new Pessoa(nome, tipo,dataDeNascimento,this.rendaDaPessoa);

            var rendaDaPessoa = new Renda(this.rendaDaPessoa);

            Assert.AreEqual(this.rendaDaPessoa, rendaDaPessoa.RendaDaPessoa);
        }

        [Test]
        public void deve_atribuir_uma_renda_a_uma_pessoa()
        {
            var renda = 2000;
            var pessoa = new Pessoa(nome, tipo, dataDeNascimento, renda);

            var rendaDaPessoa = new Renda(renda);

            Assert.AreEqual(renda, rendaDaPessoa.RendaDaPessoa);
        }

        [Test]
        public void deve_validar_se_a_renda_eh_da_pessoa()
        {
            
            var pessoa = new Pessoa(nome, tipo, dataDeNascimento, this.rendaDaPessoa);
            var pessoaExperada = new Pessoa(nome, tipo, dataDeNascimento, this.rendaDaPessoa);
            var renda = new Renda(this.rendaDaPessoa);

            var valor= renda.ValidarIdentificadorDaPessoa(pessoaExperada);

            Assert.AreEqual(0,valor);
        }
    }
}