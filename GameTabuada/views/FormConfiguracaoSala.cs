using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GameTabuada
{
    public partial class FormConfiguracaoSala : Form
    {

        ModelJogadores modelJogadores = new ModelJogadores();
        List<ModelJogadores> listaJogadores = new List<ModelJogadores>();
        Jogadores jogadores = new Jogadores();
        formJogoTabuada frmTabuda;
        public FormConfiguracaoSala(formJogoTabuada frm)
        {
            InitializeComponent();
            carregarJogadoresDataGrid();
            frmTabuda = frm;
        }


        private void carregarJogadoresDataGrid()
        {
            listaJogadores = jogadores.carregarListaJogadores();
            dtJogadores.Rows.Clear();
            if (listaJogadores != null)
            {
                foreach (ModelJogadores j in listaJogadores)
                {
                    dtJogadores.Rows.Add(j.nomeJogador);
                }
            }
        }
        private void salvarJogadores(){
            if (txtJogador.Text == "")
            {
                MessageBox.Show("Campo Jogador deve estar preenchido!");
            }
            else
            {
                modelJogadores.nomeJogador = txtJogador.Text;
                modelJogadores.idJogador = 1;
                modelJogadores.pontuacaoJogador = 10;

                try
                {
                    if (listaJogadores == null )
                    {
                        listaJogadores = new List<ModelJogadores>();
                        listaJogadores.Add(modelJogadores);
                    }
                    else
                    {
                        listaJogadores.Add(modelJogadores);
                    }
                    jogadores.salvarListaJogadores(listaJogadores);
                    MessageBox.Show("Dados salvos com sucesso!");
                    carregarJogadoresDataGrid();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao salvar jogadores! [" + erro + "]");
                }
            }
        }

        private void btnSalvarJogadores_Click(object sender, EventArgs e)
        {
            salvarJogadores();
        }
    }
}
