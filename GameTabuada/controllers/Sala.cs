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
                MessageBox.Show("Erro carregar Salas [" + erro + "]");
                return null;
            }
        }
    }
}
