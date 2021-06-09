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
            modelJogadores = jogadores.carregarJogadoresArquivoJson();
            dtJogadores.Rows.Clear();
            dtJogadores.Rows.Add(modelJogadores.nomeJogador);
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
                    jogadores.salvarDadosJogadoresArquivoJson(modelJogadores);
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
