using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorteio.Familia
{
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
