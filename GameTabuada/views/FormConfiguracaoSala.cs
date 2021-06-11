﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GameTabuada.utils;

namespace GameTabuada
{
    public partial class FormConfiguracaoSala : Form
    {

        ModelJogadores modelJogadores = new ModelJogadores();
        ModelSalas modelSala = new ModelSalas();

        List<ModelJogadores> listaJogadores = new List<ModelJogadores>();
        List<ModelSalas> listaSalas = new List<ModelSalas>();

        Jogadores jogadores = new Jogadores();
        Sala salas = new Sala();
        
        formJogoTabuada frmTabuda;
        Utils fUteis = new Utils();

        public FormConfiguracaoSala(formJogoTabuada frm)
        {
            InitializeComponent();
            carregarJogadoresDataGrid();
            carregarSalasDataGrid();
            carregarComboBoxSalasJogadores();
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
                    dtJogadores.Rows.Add(j.nomeJogador, j.salaJogador);
                }
            }
            carregarSalasDataGrid();
        }
        private void carregarSalasDataGrid()
        {
            listaSalas = salas.carregarListaSalas();
            dtSalas.Rows.Clear();
            if (listaSalas != null)
            {
                foreach (ModelSalas j in listaSalas)
                {
                    dtSalas.Rows.Add(j.nomeSala);
                }
            }
        }

        public void carregarComboBoxSalasJogadores()
        {
            listaSalas = salas.carregarListaSalas();
            if (listaSalas != null)
            {
                cbSalaJogador.Items.Clear();
                dtJogadoresCBSala.Items.Clear();
                foreach (ModelSalas j in listaSalas)
                {
                    cbSalaJogador.Items.Add(j.nomeSala);
                    dtJogadoresCBSala.Items.Add(j.nomeSala);
                }
            }
        }

        private void salvarJogadores(){
            if (txtJogador.Text == "")
            {
                 fUteis.ExibirMensagemUsuario("Campo Jogador deve estar preenchido!");
            }
            else
            {
                modelJogadores.nomeJogador = txtJogador.Text;
                modelJogadores.salaJogador = cbSalaJogador.Text;
                modelJogadores.pontuacaoJogador = 0;

                // valida se a lista está vazia, caso sim é iniciado uma nova lista
                if (listaJogadores == null)
                {
                    listaJogadores = new List<ModelJogadores>();
                }
                listaJogadores.Add(modelJogadores);

                try
                {
                    jogadores.salvarListaJogadores(listaJogadores);
                    carregarJogadoresDataGrid();
                }
                catch (Exception erro)
                {
                    fUteis.ExibirMensagemUsuario("Erro ao salvar jogadores! [" + erro + "]");
                }
            }
        }

        private void SalvarSalas()
        {
            if (txtSala.Text == "")
            {
                fUteis.ExibirMensagemUsuario("Campo Sala deve estar preenchido!");
            }
            else
            {
                modelSala.nomeSala = txtSala.Text;

                // valida se a lista está vazia, caso sim é iniciado uma nova lista
                if (listaSalas == null)
                {
                    listaSalas = new List<ModelSalas>();
                }
                listaSalas.Add(modelSala);

                try
                {
                    salas.salvarListaSalas(listaSalas);
                    carregarSalasDataGrid();
                    carregarComboBoxSalasJogadores();
                }
                catch (Exception erro)
                {
                    fUteis.ExibirMensagemUsuario("Erro ao salvar Salas! [" + erro + "]");
                }
            }
        }

        private void btnSalvarJogadores_Click(object sender, EventArgs e)
        {
            salvarJogadores();
        }

        private void btnSalvarSala_Click(object sender, EventArgs e)
        {
            SalvarSalas();
        }

        private void dtJogadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((dtJogadores.CurrentRow != null) && (dtJogadores.CurrentRow.IsNewRow == false))
            {
                txtJogador.Text = dtJogadores.CurrentRow.Cells["dtJogadoresEditJogador"].Value.ToString();
                cbSalaJogador.Text = dtJogadores.CurrentRow.Cells["dtJogadoresCBSala"].Value.ToString();
            }
        }

        public void ExcluirJogador()
        {
            // valida se a linha atual é nova 
            if ((dtJogadores.CurrentRow != null) && (dtJogadores.CurrentRow.IsNewRow == false))
            {
                // Pega o nome do jogador atual
                string jogador = dtJogadores.CurrentRow.Cells["dtJogadoresEditJogador"].Value.ToString();
                if (fUteis.ConfirmarAcaoUsuario("Deseja realmente excluir o jogador " + jogador + " ?"))
                {
                    // realiza a tentativa de exclusão do jogador
                    try
                    {
                        jogadores.excluirJogadorArquivoJson(jogador);
                        carregarJogadoresDataGrid();
                    }catch(Exception erro)
                    {
                        fUteis.ExibirMensagemUsuario("Erro ao excluir jogador ["+erro+"]!");
                    }
                }
            }
        }

        public void ExcluirSala()
        {
            // valida se a linha atual é nova 
            if ((dtSalas.CurrentRow != null) && (dtSalas.CurrentRow.IsNewRow == false))
            {
                // Pega o nome da sala atual
                string sala = dtSalas.CurrentRow.Cells["dtSalasEditSala"].Value.ToString();
                if (fUteis.ConfirmarAcaoUsuario("Deseja realmente excluir a sala " + sala + " ?"))
                {
                    // realiza a tentativa de exclusão do jogador
                    try
                    {
                        salas.excluirSalaArquivoJson(sala);
                        carregarSalasDataGrid();
                    }
                    catch (Exception erro)
                    {
                        fUteis.ExibirMensagemUsuario("Erro ao excluir sala [" + erro + "]!");
                    }
                }
            }
        }
        private void btnExcluirJogador_Click(object sender, EventArgs e)
        {
            ExcluirJogador();
        }
        private void btnExcluirSala_Click(object sender, EventArgs e)
        {
            ExcluirSala();
        }

        private void txtJogador_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                salvarJogadores();
                txtJogador.SelectAll();
            }
        }
        private void txtSala_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SalvarSalas();
                txtSala.SelectAll();
            }

        }

        private void FormConfiguracaoSala_Shown(object sender, EventArgs e)
        {
            txtJogador.Focus();
        }

        private void dtJogadores_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ExcluirJogador();
            }
        }

        private void dtSalas_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ExcluirSala();
            }
        }
    }
}
