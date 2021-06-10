namespace GameTabuada
{
    public class ModelConfiguracoes
    {
        public int limiteFatorA { get; set; }
        public int limiteNegativoFatorA { get; set; }
        public int limiteNegativoFatorB { get; set; }
        public int limiteFatorB { get; set; }
        public bool fixarFatorA { get; set; }
        public int qtdMinutos { get; set; }
        public int qtdSegundos { get; set; }
        public bool operacoesDeDivisao { get; set; }
        public bool operacoesDeMultiplicacao { get; set; }
        public bool operacoesDeAdicao { get; set; }
        public bool operacoesDeSubtracao { get; set; }
        public int qtdCasasDecimaisResultadoDivisao{ get; set; }
    }
}
