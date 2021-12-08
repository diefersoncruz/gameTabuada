using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GameTabuada
{
    public partial class FormResultado : Form
    {

        ModelJogadores modelJogadores = new ModelJogadores();
        List<ModelJogadores> listaJogadores = new List<ModelJogadores>();
        Jogadores jogadores = new Jogadores();        
        formJogoTabuada frmTabuda;

        string pSala = ""; 

        public FormResultado(formJogoTabuada frm, string sala)
        {
            InitializeComponent();
            carregarResultadoDataGrid();
            frmTabuda = frm;
            pSala = sala;
        }


        private void carregarResultadoDataGrid()
        {
            listaJogadores = jogadores.carregarListaJogadores();
            dtResultado.Rows.Clear();
            if (listaJogadores != null)
            {
                foreach (ModelJogadores j in listaJogadores)
                {
                    if (pSala == "Sala XX" || pSala == "")
                    {
                        dtResultado.Rows.Add(j.salaJogador, j.nomeJogador, j.pontuacaoJogador);
                    }
                    else
                    {
                        if (pSala == j.salaJogador)
                        {
                            dtResultado.Rows.Add(j.salaJogador, j.nomeJogador, j.pontuacaoJogador);
                        }
                    }
                }
            }
        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            carregarResultadoDataGrid();
        }
    }
}
