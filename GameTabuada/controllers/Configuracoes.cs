using System;
using System.Windows.Forms;
using System.Text.Json;
using GameTabuada.utils;

namespace GameTabuada
{
    public class Configuracoes
    {
        Utils fUteis = new Utils();

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
            fUteis.gravarArquivoJson("configuracoesUsuarios.json", dados);
        }
        public ModelConfiguracoes carregarConfiguracoesArquivoJson()
        {
            ModelConfiguracoes dados = new ModelConfiguracoes();
            try
            {
                if (fUteis.getFileExits("configuracoesUsuarios.json"))
                {
                    return JsonSerializer.Deserialize<ModelConfiguracoes>(fUteis.lerArquivo("configuracoesUsuarios.json")); ;
                }
                else{
                    gerarArquivoConfiguracoesPadrao();
                    return dados; 
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro carregar informações do usuário " + erro);
                return dados;
            }
        }
    }
}
