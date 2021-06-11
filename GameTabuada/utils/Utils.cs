using GameTabuada.controllers;
using System;
using System.Text.Json;
using System.IO;
using System.Windows.Forms;

namespace GameTabuada.utils
{
    public class Utils
    {
        JsonConversao jsonConversao = new JsonConversao();
        public void gravarArquivoJson<T>(string fileName, T obj)
        {
            try
            {
                string jsonFile = JsonSerializer.Serialize<T>(obj); ;
                File.WriteAllText(fileName, jsonFile);
            }
            catch (Exception erro)
            {
                ExibirMensagemUsuario("Erro salvar dados [" + erro + ']');
            }
        }
        public void gravarListaArquivoJson<T>(string fileName, T objList)
        {
            try
            {
                string jsonFile = jsonConversao.ConverteObjectParaJSon(objList);
                File.WriteAllText(fileName, jsonFile);
            }
            catch (Exception erro)
            {
                ExibirMensagemUsuario("Erro salvar dados [" + erro + ']');
            }
        }

        public string lerArquivo(string fileName)
        {
            if (getFileExits(fileName))
            {
                try
                {
                    return File.ReadAllText(fileName);
                }
                catch (Exception erro)
                {
                    ExibirMensagemUsuario("Falha ao ler ao arquivo (" + fileName + ") [" + erro + ']');
                    return "";
                }
            }else
            {
                ExibirMensagemUsuario("Arquivo ( "+fileName+" ) não encontrado!");
                return null;
            }
        }

        public Boolean getFileExits(string fileName)
        {
            return File.Exists(fileName);
        }

        public bool ConfirmarAcaoUsuario(string message)
        {
            DialogResult result = MessageBox.Show(message, "Confirmar", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) {return true;}
            else { return false; }
        }

        public void ExibirMensagemUsuario(string message)
        {
            MessageBox.Show(message);
        }
    }
}
