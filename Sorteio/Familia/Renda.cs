using System;

namespace Sorteio.Familia
{
    public class Renda
    {
        public decimal RendaDaPessoa { get; set; }
        public Guid IdentificadorDaPessoa { get; set; }

        public Renda(decimal renda)
        {
            this.RendaDaPessoa = renda;
        }

        public int ValidarIdentificadorDaPessoa(Pessoa pessoa)
        {
            var valor = IdentificadorDaPessoa.CompareTo(pessoa.IdentificadoDePessoa);
            if (valor == -1 || valor == 1)
            {
                return 1;
                throw new ArgumentException("pessoas diferentes");
            }

            return 0;
        }
    }
}
