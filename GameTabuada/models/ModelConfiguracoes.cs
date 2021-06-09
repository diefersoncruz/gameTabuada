using System;

namespace GameTabuada
{
    public class ModelConfiguracoes
    {
        public int limiteFatorA { get; set; }
        public int limiteNegativoFatorA { get; set; }
        public int limiteNegativoFatorB { get; set; }
        public int limiteFatorB { get; set; }
        public Boolean fixarFatorA { get; set; }
        public int qtdMinutos { get; set; }
        public int qtdSegundos { get; set; }
        public Boolean operacoesDeDivisao { get; set; }
        public Boolean operacoesDeMultiplicacao { get; set; }
        public Boolean operacoesDeAdicao { get; set; }
        public Boolean operacoesDeSubtracao { get; set; }
        public int qtdCasasDecimaisResultadoDivisao{ get; set; }
    }
}
