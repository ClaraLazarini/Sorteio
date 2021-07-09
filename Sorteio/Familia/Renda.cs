using System;

namespace Sorteio.Familia
{
    public class Renda
    {
        /**
         * Encapsulamento dos sets
         * Não precisa do identificar para familia
         * Não precisa validar o identificar de familia
         * O nome "RendaDaPessoa" não é claro, esse é o valor da renda
         */
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
