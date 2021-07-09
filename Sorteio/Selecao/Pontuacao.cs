
namespace Sorteio.Selecao
{
    public class Pontuacao
    {
        private Familia.Familia _familia;

        public Pontuacao(Familia.Familia familia)
        {
            _familia = familia;
        }

        public int ObterPorRendaDaFamilia()
        {
            var rendaTotalFamilia = _familia.ObterValorTotalDaRenda();
            var pontuacaoPorRenda = 0;

            if (rendaTotalFamilia <= 900)
            {
                pontuacaoPorRenda = 5;
            }else {
                if (rendaTotalFamilia >= 901 && rendaTotalFamilia <= 1500)
                {
                    pontuacaoPorRenda = 3;
                }
                else {
                    if (rendaTotalFamilia >= 1501 && rendaTotalFamilia <= 2000)
                    {
                        pontuacaoPorRenda = 1;
                    }
                }
            }
            return pontuacaoPorRenda;
        }

        public int ObterPorIdadeDoPretendente()
        {
            var idadeDoPretendente = _familia.ObterIdadeDoPretendente();
            var pontuacaoPorIdade = 1;

            if (idadeDoPretendente >= 45)
            {
                pontuacaoPorIdade = 3;
            }
            else {
                if (idadeDoPretendente >= 30)
                {
                    pontuacaoPorIdade = 2;
                }
            }
            return pontuacaoPorIdade;
        }

        public int ObterPorQuantidadeDeDependentes()
        {
            var numeroDeDependentes = _familia.ObterQuantidadeDeIntegrantesMenorDeIdade();
            var pontuacao = 0;
            if (numeroDeDependentes >= 3)
            {
                pontuacao = 3;
            }
            else
            {
                if (numeroDeDependentes > 0)
                {
                    pontuacao = 2;
                }
            }

            return pontuacao;
        }

        public int ObterPontuacaoTotal()
        {
            var total = ObterPorIdadeDoPretendente() + ObterPorQuantidadeDeDependentes() + ObterPorRendaDaFamilia();
            return total;
        }
    }
}
