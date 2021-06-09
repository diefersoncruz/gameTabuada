using System;
using System.IO;
using System.Windows.Forms;

namespace GameTabuada.utils
{
    public class Utils
    {
        public void gravarArquivoJson(string fileName, string jsonString)
        {
            try
            {
                string aux = File.ReadAllText(fileName);
                aux = aux + jsonString;
                File.WriteAllText(fileName, aux);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro salvar dados [" + erro + ']');
            }
        }

        public string lerArquivo(string fileName)
        {
            try
            {
                return File.ReadAllText(fileName);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao ler ao arquivo ("+fileName+") [" + erro + ']');
                return "";
            }
        }

        public Boolean getFileExits(string fileName)
        {
            return File.Exists(fileName);
        }
    }
}
