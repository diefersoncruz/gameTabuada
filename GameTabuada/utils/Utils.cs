using GameTabuada.controllers;
using System;
using System.Text.Json;
using System.IO;
using System.Windows.Forms;
using GameTabuada.views;

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


        public void ExibirMensagemUsuario(string mensagem)
        {
            FormMsg formMsg = new FormMsg(mensagem, "OK", "", false);
            formMsg.ShowDialog();
        }
        public bool ConfirmarAcaoUsuario(string mensagem, string msgBtnOK = "Sim", string msgBtnCancel = "Não")
        {
            FormMsg formMsg = new FormMsg(mensagem, msgBtnOK, msgBtnCancel);
            formMsg.ShowDialog();

            if (formMsg.DialogResult == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
