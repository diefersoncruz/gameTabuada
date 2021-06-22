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


        public bool JogadorJaCadastrado(string jogador, string sala)
        {
            List<ModelJogadores> listaJogadores = new List<ModelJogadores>();
            listaJogadores = carregarListaJogadores();
            bool jogadorJaCadastrado = false;

            // percorre a lista de jogadores
            foreach (ModelJogadores j in listaJogadores)
            {
                if ((j.nomeJogador == jogador) &&(j.salaJogador == sala))
                {
                    jogadorJaCadastrado = true;
                    break;
                }
            }

            return jogadorJaCadastrado;
        }

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
                fUteis.ExibirMensagemUsuario("Erro carregar os jogadores[" + erro + "]");
                return null;
            }
        }
        public List<ModelJogadores> carregarListaJogadoresSala(string sala)
        {
            if (fUteis.getFileExits(fileName) == false)
            {
                gerarArquivoJogadoresPadrao();
            }
            try
            {
                List<ModelJogadores> listaJogadores = new List<ModelJogadores>();
                listaJogadores = jsonConversao.ConverteJSonParaObject<List<ModelJogadores>>(fUteis.lerArquivo(fileName));
                // percorre lista de jogadores e excluí jogadores que não são da lista selecionada
                foreach (ModelJogadores j in listaJogadores)
                {
                    if (j.salaJogador != sala)
                    {
                        listaJogadores.Remove(j);
                    }
                }
                return listaJogadores;
            }
            catch (Exception erro)
            {
                fUteis.ExibirMensagemUsuario("Erro carregar os jogadores[" + erro + "]");
                return null;
            }
        }

        public void excluirJogadorArquivoJson(string jogador)
        {
            // inicia as variaveis
            List<ModelJogadores> listaJogadores = new List<ModelJogadores>();
            listaJogadores = carregarListaJogadores();
            bool jogadorExcluido = false;

            // Percorre lista de jogadores
            if (listaJogadores != null)
            {
                // percorre a lista de jogadores
                foreach (ModelJogadores j in listaJogadores)
                {
                    if (j.nomeJogador == jogador)
                    {
                        listaJogadores.Remove(j);
                        jogadorExcluido = true;
                        break;
                    }
                }
            }
            // salva nova lista de jogadores
            if (jogadorExcluido) 
            {
                salvarListaJogadores(listaJogadores);
            }
        }
    }
}
