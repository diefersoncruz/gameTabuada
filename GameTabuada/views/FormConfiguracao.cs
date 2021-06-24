using GameTabuada.utils;
using System;
using System.Windows.Forms;

namespace GameTabuada
{
    public partial class FormConfiguracao : Form
    {
        Configuracoes configuracoes;
        ModelConfiguracoes dadosConfiguracoes;
        formJogoTabuada frmTabuda;
        Utils fUteis = new Utils();
        public FormConfiguracao(formJogoTabuada frm)
        {
            InitializeComponent();
            configuracoes = new Configuracoes();
            dadosConfiguracoes = new ModelConfiguracoes();

            dadosConfiguracoes = configuracoes.carregarConfiguracoesArquivoJson();
            preencherConfiguracoesUsuario(dadosConfiguracoes);
            frmTabuda = frm;
        }

        private void preencherConfiguracoesUsuario(ModelConfiguracoes dados)
        {
            txtConfigLimiteFatorA.Text = dados.limiteFatorA.ToString();
            txtConfigLimiteFatorB.Text = dados.limiteFatorB.ToString();
            txtConfigLimiteNegativoFatorA.Text = dados.limiteNegativoFatorA.ToString();
            txtConfigLimiteNegativoFatorB.Text = dados.limiteNegativoFatorB.ToString();
            txtQtdMinutos.Text = dados.qtdMinutos.ToString();
            txtQtdSegundos.Text = dados.qtdSegundos.ToString();
            cbDivisao.Checked = dados.operacoesDeDivisao;
            cbMultiplicacao.Checked = dados.operacoesDeMultiplicacao;
            cbAdicao.Checked = dados.operacoesDeAdicao;
            cbSubtracao.Checked = dados.operacoesDeSubtracao;
        }
        private void salvarConfiguracoes()
        {
            // carrega as informações na classe
            dadosConfiguracoes.limiteFatorA = Convert.ToInt32(txtConfigLimiteFatorA.Text);
            dadosConfiguracoes.limiteFatorB = Convert.ToInt32(txtConfigLimiteFatorB.Text);
            dadosConfiguracoes.limiteNegativoFatorA = Convert.ToInt32(txtConfigLimiteNegativoFatorA.Text);
            dadosConfiguracoes.limiteNegativoFatorB = Convert.ToInt32(txtConfigLimiteNegativoFatorB.Text);
            dadosConfiguracoes.qtdMinutos = Convert.ToInt32(txtQtdMinutos.Text);
            dadosConfiguracoes.qtdSegundos = Convert.ToInt32(txtQtdSegundos.Text);
            dadosConfiguracoes.operacoesDeDivisao = cbDivisao.Checked;
            dadosConfiguracoes.operacoesDeMultiplicacao = cbMultiplicacao.Checked;
            dadosConfiguracoes.operacoesDeAdicao = cbAdicao.Checked;
            dadosConfiguracoes.operacoesDeSubtracao = cbSubtracao.Checked;
            //salva informações no arquivo Json
            try
            {
                configuracoes.salvarConfiguracoes(dadosConfiguracoes);
                // exibe mensagem
                fUteis.ExibirMensagemUsuario("Dados Salvos com sucesso!");
                // fecha a tela de configuracoes
                this.Dispose();
                frmTabuda.carregarConfiguracoesJson();
            }
            catch(Exception erro)
            {
                fUteis.ExibirMensagemUsuario("Erro ao salvar arquivo" + erro);
            }
        }

        private Boolean getConfiguracoesValidas()
        {
            if ((cbDivisao.Checked == false) && (cbMultiplicacao.Checked == false) && (cbAdicao.Checked == false) && (cbSubtracao.Checked == false))
            {
                fUteis.ExibirMensagemUsuario("Ao menos uma operação matemática deverá ser selecionada!");
                return false;
            }
            else 
            { 
                return 
                    true; 
            }
        }

        private void btnSalvarConfiguracoes_Click(object sender, EventArgs e)
        {
            if (getConfiguracoesValidas())
            {
                salvarConfiguracoes();
            }
        }

        private void FormConfiguracao_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                salvarConfiguracoes();
            }
        }
    }
}
