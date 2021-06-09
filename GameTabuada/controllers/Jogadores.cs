using System;
using System.Windows.Forms;
using System.Text.Json;
using GameTabuada.utils;
using System.Collections.Generic;

namespace GameTabuada
{
    public class Jogadores
    {
        Utils fUteis = new Utils();
        string fileName = "dadosJogadores.json";
        public IList<ModelJogadores> listaJogadores { get; set; }

        public void salvarDadosJogadoresArquivoJson(ModelJogadores jogadores)
        {
            fUteis.gravarArquivoJson(fileName, JsonSerializer.Serialize(jogadores));
        }
        public ModelJogadores carregarJogadoresArquivoJson()
        {
            ModelJogadores dados = new ModelJogadores();
            try
            {
               if (fUteis.getFileExits(fileName))
                {
                    return JsonSerializer.Deserialize<ModelJogadores>(fUteis.lerArquivo(fileName)); 
                }
               else
                {
                    return dados;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro carregar os jogadores[" + erro + "]");
                return dados;
            }
        }

    }
}
