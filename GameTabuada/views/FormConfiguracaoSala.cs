using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
                MessageBox.Show("Campo Jogador deve estar preenchido!");
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
                    MessageBox.Show("Dados salvos com sucesso!");
                    carregarJogadoresDataGrid();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao salvar jogadores! [" + erro + "]");
                }
            }
        }

        private void SalvarSalas()
        {
            if (txtSala.Text == "")
            {
                MessageBox.Show("Campo Sala deve estar preenchido!");
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
                    MessageBox.Show("Dados salvos com sucesso!");
                    carregarSalasDataGrid();
                    carregarComboBoxSalasJogadores();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao salvar Salas! [" + erro + "]");
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
    }
}
