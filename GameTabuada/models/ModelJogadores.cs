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
    public class ModelJogadores
    {
        public int idJogador { get; set; }
        public string nomeJogador { get; set; }
        public int pontuacaoJogador { get; set; }
    }
}
