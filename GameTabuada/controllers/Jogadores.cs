using System;
using System.Windows.Forms;
using System.Text.Json;
using GameTabuada.utils;
using GameTabuada.controllers;
using System.Collections.Generic;

namespace GameTabuada
{
    public class Jogadores
    {
        string fileName = "dadosJogadores.json";
        Utils fUteis = new Utils();
        JsonConversao jsonConversao = new JsonConversao();

        public void gerarArquivoJogadoresPadrao()
        {
            ModelJogadores jogadores = new ModelJogadores();
            jogadores.nomeJogador = "Jogador01";
            fUteis.gravarArquivoJson(fileName,   jogadores);
        }
        public void salvarListaJogadores(List<ModelJogadores> listaJogadores)
        {
            fUteis.gravarListaArquivoJson(fileName, listaJogadores);
        }
        public List<ModelJogadores> carregarListaJogadores()
        {
            if (fUteis.getFileExits(fileName)== false)
            {
                gerarArquivoJogadoresPadrao();
            }
            try
            {
                    List<ModelJogadores> listaJogadores = new List<ModelJogadores>();
                    listaJogadores = jsonConversao.ConverteJSonParaObject<List<ModelJogadores>>(fUteis.lerArquivo(fileName));
                    return listaJogadores; 
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro carregar os jogadores[" + erro + "]");
                return null;
            }
        }

    }
}
