using GameTabuada.utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GameTabuada
{
    public partial class FormOpcoesJogo : Form
    {
        ModelSalas modelSala = new ModelSalas();
        List<ModelSalas> listaSalas = new List<ModelSalas>();
        Sala salas = new Sala();
        Utils fUteis = new Utils();
        formJogoTabuada frmTabuada = new formJogoTabuada();
        public FormOpcoesJogo(formJogoTabuada frm)
        {
            InitializeComponent();
            carregarComboBoxSalasJogadores();
            frmTabuada = frm;
        }

        public void carregarComboBoxSalasJogadores()
        {
            listaSalas = salas.carregarListaSalas();
            if (listaSalas != null)
            {
                cbSelecaoSalaJogo.Items.Clear();
                foreach (ModelSalas j in listaSalas)
                {
                    cbSelecaoSalaJogo.Items.Add(j.nomeSala);
                }
            }
        }

        private void cbJogadorUnico_CheckedChanged(object sender, EventArgs e)
        {
            cbSelecaoSalaJogo.Enabled = !cbJogadorUnico.Checked;
        }

        private void btnIniciarJogo_Click(object sender, EventArgs e)
        {
            // Preenche as varíaveis globais de controle de jogo
            frmTabuada.pFormTabuadaNumeroRodadas = Convert.ToInt32(txtNumeroRodadas.Text);
            frmTabuada.pFormTabuadaSalaJogo = cbSelecaoSalaJogo.Text;
            frmTabuada.bJogadorUnico = false;
            // valida seleção do jogo
            if (cbSelecaoSalaJogo.Text == "")
            {
                if (fUteis.ConfirmarAcaoUsuario("Atenção! Não foi informado sala, portanto jogo será iniciado com jogador único!"))
                {
                    frmTabuada.bJogadorUnico = true;
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void txtNumeroRodadas_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Convert.ToInt32(txtNumeroRodadas.Text);
            }catch
            {
                fUteis.ExibirMensagemUsuario("Informe um número válido!");
                txtNumeroRodadas.Focus();
            }
        }
    }
}
