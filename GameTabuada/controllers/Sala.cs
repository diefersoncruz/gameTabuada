using GameTabuada.controllers;
using GameTabuada.utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GameTabuada
{
    public class Sala
    {
        string fileName = "dadosSalas.json";
        Utils fUteis = new Utils();
        JsonConversao jsonConversao = new JsonConversao();

        public void gerarArquivoSalaPadrao()
        {
            ModelSalas salas = new ModelSalas();
            salas.nomeSala = "Sala01";
            fUteis.gravarArquivoJson(fileName, salas);
        }

        public bool salaJaCadasrtrada(string sala)
        {
            List<ModelSalas> listaSalas = new List<ModelSalas>();
            listaSalas = carregarListaSalas();
            bool salaJaCadastrada = false;

            // percorre a lista de salas
            foreach (ModelSalas j in listaSalas)
            {
                if (j.nomeSala == sala) 
                {
                    salaJaCadastrada = true;
                    break;
                }
            }

            return salaJaCadastrada;
        }

        public void salvarListaSalas(List<ModelSalas> listaSalas)
        {
            fUteis.gravarListaArquivoJson(fileName, listaSalas);
        }
        
        public List<ModelSalas> carregarListaSalas()
        {
            if (fUteis.getFileExits(fileName) == false)
            {
                gerarArquivoSalaPadrao();
            }
            try
            {
                List<ModelSalas> listaSalas = new List<ModelSalas>();
                listaSalas = jsonConversao.ConverteJSonParaObject<List<ModelSalas>>(fUteis.lerArquivo(fileName));
                return listaSalas;
            }
            catch (Exception erro)
            {
                fUteis.ExibirMensagemUsuario("Erro carregar Salas [" + erro + "]");
                return null;
            }
        }

        public void excluirSalaArquivoJson(string sala)
        {
            // inicia as variaveis
            List<ModelSalas> listaSalas = new List<ModelSalas>();
            listaSalas = carregarListaSalas();
            bool salaExcluida = false;

            // Percorre lista de salas
            if (listaSalas != null)
            {
                // percorre a lista de jogadores
                foreach (ModelSalas j in listaSalas)
                {
                    if (j.nomeSala == sala)
                    {
                        listaSalas.Remove(j);
                        salaExcluida = true;
                        break;
                    }
                }
            }
            // salva nova lista de jogadores
            if (salaExcluida)
            {
                salvarListaSalas(listaSalas);
            }
        }
    }
}
