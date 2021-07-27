using System;
using System.Windows.Forms;
using System.Text.Json;
using GameTabuada.utils;

namespace GameTabuada
{
    public class Configuracoes
    {
        Utils fUteis = new Utils();

        public string fileNameConfiguracoes = "configuracoesUsuarios.json";

        private void gerarArquivoConfiguracoesPadrao()
        {
            ModelConfiguracoes dados = new ModelConfiguracoes();

            dados.limiteFatorA = 10;
            dados.limiteNegativoFatorA = 0;
            dados.limiteFatorB = 10;
            dados.limiteNegativoFatorB = 0;
            dados.qtdMinutos = 0;
            dados.qtdSegundos = 60;
            dados.operacoesDeDivisao = true;
            dados.operacoesDeMultiplicacao = true;
            dados.operacoesDeAdicao = true;
            dados.operacoesDeSubtracao = true;
            dados.qtdCasasDecimaisResultadoDivisao = 0;

            salvarConfiguracoes(dados);
        }
        public void salvarConfiguracoes(ModelConfiguracoes dados)
        {
            fUteis.gravarArquivoJson(fileNameConfiguracoes, dados);
        }
        public ModelConfiguracoes carregarConfiguracoesArquivoJson()
        {
            ModelConfiguracoes dados = new ModelConfiguracoes();
            try
            {
                if (fUteis.getFileExits(fileNameConfiguracoes))
                {
                    return JsonSerializer.Deserialize<ModelConfiguracoes>(fUteis.lerArquivo(fileNameConfiguracoes)); ;
                }
                else{
                    gerarArquivoConfiguracoesPadrao();
                    return dados; 
                }
            }
            catch (Exception erro)
            {
                fUteis.ExibirMensagemUsuario("Erro carregar informações do usuário " + erro);
                return dados;
            }
        }
    }
}
