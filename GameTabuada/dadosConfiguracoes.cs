using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Windows.Forms;

namespace GameTabuada
{
    public class dadosConfiguracoes
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

        private void gerarArquivoConfiguracoesPadrao()
        {
            dadosConfiguracoes dados = new dadosConfiguracoes();

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

            salvarConfiguracoesArquivoJson(dados);
        }
        public void salvarConfiguracoesArquivoJson(dadosConfiguracoes dados)
        {
            try
            {
                using (var streamWriter = new StreamWriter("ConfiguracoesUsuarios.json"))
                {
                    string json = new JavaScriptSerializer().Serialize(new
                    {
                        LimiteFatorA = dados.limiteFatorA,
                        limiteNegativoFatorA = dados.limiteNegativoFatorA,
                        limiteNegativoFatorB = dados.limiteNegativoFatorB,
                        LimiteFatorB = dados.limiteFatorB,
                        FixarFatorA = dados.fixarFatorA,
                        QtdMinutos = dados.qtdMinutos,
                        QtdSegundos = dados.qtdSegundos,
                        operacoesDeDivisao = dados.operacoesDeDivisao,
                        operacoesDeMultiplicacao = dados.operacoesDeMultiplicacao,
                        operacoesDeAdicao = dados.operacoesDeAdicao,
                        operacoesDeSubtracao = dados.operacoesDeSubtracao,
                        qtdCasasDecimaisResultadoDivisao = dados.qtdCasasDecimaisResultadoDivisao

                    });; ;

                    streamWriter.Write(json);
                }
            }catch(Exception erro)
            {
                MessageBox.Show("Erro salvar dados [" + erro+']');
            }
        }
        public dadosConfiguracoes carregarConfiguracoesArquivoJson()
        {
            dadosConfiguracoes dados = new dadosConfiguracoes();
            try
            {
                if (File.Exists("ConfiguracoesUsuarios.json"))
                {
                    dados = JsonConvert.DeserializeObject<dadosConfiguracoes>(File.ReadAllText("ConfiguracoesUsuarios.json"));
                    return dados;
                }else
                {
                    gerarArquivoConfiguracoesPadrao();
                    dados = JsonConvert.DeserializeObject<dadosConfiguracoes>(File.ReadAllText("ConfiguracoesUsuarios.json"));
                    return dados;
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro carregar informações do usuário " + erro);
                return dados;
            }
        }
    }
}
