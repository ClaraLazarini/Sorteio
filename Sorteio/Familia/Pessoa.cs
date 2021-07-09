using System;

namespace Sorteio.Familia
{
    /**
     * Mesma questão do encapsulamento dos sets
     * Idade dá para ser uma property calculada
     * ObterCalculoIdade não é um nome claro
     */
    public class Pessoa
    {
        public Guid IdentificadoDePessoa { get; set; }
        public string Nome { get; set; }
        public Tipo Tipo { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public Renda Renda { get; set; }

        public Pessoa(string nome, Tipo tipo, DateTime dataDeNascimento, decimal renda)
        {
            this.IdentificadoDePessoa = new Guid();
            this.Nome = nome;
            this.Tipo = tipo;
            this.DataDeNascimento = dataDeNascimento;
            this.Renda = new Renda(renda);
        }

        public int ObterCalculoIdade()
        {
            var anoAtual = DateTime.Now.Year;
            var idade = anoAtual - DataDeNascimento.Year;

            if (DataDeNascimento.Month > DateTime.Now.Month)
            {
                idade--;
            }

            return idade;
        }
    }
}