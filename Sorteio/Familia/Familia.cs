using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorteio.Familia
{
    /**
     * Cuidar do encapsulamento, deixar os sets sem acesso público
     * Caprichar mais no clean code, por exemplo ObterValorTotalDaRenda CalcularRendaTotal
     * Extrair comportamento de validação se é menor de idade para Pessoa
     */
    public class Familia
    {
        public Guid IdentificadorDeFamilia { get; set; }
        public List<Pessoa> PessoasDaFamilia { get; set; }
        public Status Status { get; set; }

        public Familia( List<Pessoa> pessoasDaFamilia, Status status)
        {
            this.IdentificadorDeFamilia = new Guid();
            this.PessoasDaFamilia = pessoasDaFamilia;
            this.Status = status;
        }

        public decimal ObterValorTotalDaRenda()
        {
            var valorTotal = PessoasDaFamilia.Sum(pessoa => pessoa.Renda.RendaDaPessoa);
            return valorTotal;
        }

        public int ObterIdadeDoPretendente()
        {
            var pretendente = PessoasDaFamilia.Find(pessoa => pessoa.Tipo == Tipo.Pretendente);
            var idade = pretendente.ObterCalculoIdade();
            return idade;
        }

        public int ObterQuantidadeDeIntegrantes()
        {
            var quantidade = PessoasDaFamilia.Count;
            return quantidade;
        }

        public int ObterQuantidadeDeIntegrantesMenorDeIdade()
        {
            var menoresIdade = PessoasDaFamilia.Where(pessoa => pessoa.ObterCalculoIdade() < 18).ToList();
            var quantidade = menoresIdade.Count;
            return quantidade;
        }
    }
}
