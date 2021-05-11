using System;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTabuada
{
    public partial class formJogoTabuada : Form
    {
        int fator = 0;
        int multiplicador = 0;
        int fatorOld = 0;
        int limiteFatorA = 0;
        int limiteFatorB = 0;
        int limiteNegativoFatorA = 0;
        int limiteNegativoFatorB = 0;
        double resultadoOperacao = 0;
        int qtdAcertosUsuario = 0;
        int qtdErrosUsuario = 0;
        int qtdMinutos = 0;
        int qtdSegundos = 0;
        int tempoTotalSegundos = 0;
        dadosConfiguracoes dadosConfigurados;

        public formJogoTabuada()
        {
            InitializeComponent();
            dadosConfigurados = new dadosConfiguracoes();
            carregarConfiguracoesJson();
        }
        public void carregarConfiguracoesJson()
        {
            dadosConfigurados = dadosConfigurados.carregarConfiguracoesArquivoJson();
        }
        public void carregarConfiguracoesJogo()
        {
            qtdMinutos = dadosConfigurados.qtdMinutos;
            qtdSegundos = dadosConfigurados.qtdSegundos;
            limiteFatorA = dadosConfigurados.limiteFatorA;
            limiteFatorB = dadosConfigurados.limiteFatorB;
            limiteNegativoFatorA = dadosConfigurados.limiteNegativoFatorA;
            limiteNegativoFatorB = dadosConfigurados.limiteNegativoFatorB;
            tempoTotalSegundos = qtdMinutos * 60 + qtdSegundos;
        }

        public Boolean getJogoEmAndamento()
        {
            if (timerDuracao.Enabled)
            {
                timerDuracao.Stop();
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean confirmarInicioNovoJogo()
        {
            // valida se existe um jogo em andamento
            if (getJogoEmAndamento())
            {
                string message = "Deseja Realmente iniciar um novo jogo?";
                string caption = "Confirmar Inicio novo Jogo";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                // valida o retorno do usuário
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    return true;
                }
                else
                {
                    timerDuracao.Start();
                    return false;
                }
            } // caso não haja jogo em andamento retorna true
            else
            {
                return true;
            }
        }
        public Boolean confirmarAberturaTelaConfiguracao()
        {
            // valida se existe um jogo em andamento
            if (getJogoEmAndamento())
            {
                string message = "Deseja Realmente abrir a tela de configurações? Isso irá parar o jogo atual!";
                string caption = "Confirmar abertura tela configurações";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                // valida o retorno do usuário
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    return true;
                }
                else
                {
                    timerDuracao.Start();
                    return false;
                }
            } // caso não haja jogo em andamento retorna true
            else
            {
                return true;
            }
        }


        public void IniciarJogo()
        {   // valida se é será iniciado um novo jogo
            if (confirmarInicioNovoJogo())
            {
                carregarConfiguracoesJogo();
                zerarVariaveis();
                setarQtdAcertos("0");
                setarQtdErros("0");
                LimparDadosTxtResultado();
                GeradorGameMatematica();
                txtResultado.ReadOnly = false;
                txtResultado.Enabled = true;
                timerDuracao.Enabled = true;
                txtResultado.Focus();
            }
        }

        private void ValidarRespostaUsuario()
        {
            // pega o resultado do usuário
            try
            {
                double resultadoUsuario = Convert.ToDouble(getTxtResultado());
                resultadoOperacao = Math.Round(resultadoOperacao,dadosConfigurados.qtdCasasDecimaisResultadoDivisao);
                // valida o resultado 
                if (resultadoOperacao == resultadoUsuario)
                {
                    qtdAcertosUsuario += 1;
                    setarQtdAcertos(qtdAcertosUsuario.ToString());
                }
                else
                {
                    qtdErrosUsuario += 1;
                    setarQtdErros(qtdErrosUsuario.ToString());
                }
                LimparDadosTxtResultado();
                GeradorGameMatematica();
            }
            catch
            {
                LimparDadosTxtResultado();
            }

        }


        public void preencherDadosMultiplicadorFatorTela()
        {
            // preenche o fator e o mutiplicadorgerado randomicamente
            setarFator(fator.ToString());
            setarMultiplicador(multiplicador.ToString());
        }
        public void gerarFatoresOperacaoMatematica()
        {
            Random rnd = new Random();
            while (fatorOld == fator)
            {
                fator = Convert.ToInt32(rnd.Next(limiteNegativoFatorA, limiteFatorA).ToString());
                multiplicador = Convert.ToInt32(rnd.Next(limiteNegativoFatorB, limiteFatorB).ToString());
            }
        }
        public void gerarFatoresOperacaoMatematicaDivisao()
        {
            Random rnd = new Random();
            while (fatorOld == fator)
            {
                fator = Convert.ToInt32(rnd.Next(limiteNegativoFatorA, limiteFatorA).ToString());
                multiplicador = Convert.ToInt32(rnd.Next(limiteNegativoFatorB, limiteFatorB).ToString());
                // valida se o fator é igual a 0
                if (fator == 0)
                {
                    fator += 1;
                }
                // valida se o multiplicador é igual a 0
                if (multiplicador == 0)
                {
                    multiplicador += 1;
                }
                // valida se o resultado da operação tem resto 0 
                while (fator % multiplicador != 0)
                {
                    multiplicador = Convert.ToInt32(rnd.Next(limiteNegativoFatorB, limiteFatorB).ToString());
                    fator = Convert.ToInt32(rnd.Next(limiteNegativoFatorA, limiteFatorA).ToString());
                    // valida se o multiplicador é igual a 0
                    if ((multiplicador == 0 ) || (fator == 0) )
                    { 
                        fator = 1;
                        multiplicador = 3;
                    }
                }
            }
        }
        public void GeradorGameMatematica()
        {
            fatorOld = fator;
            Random rnd = new Random();
            Boolean opcaoValida = false;

            int operadorMatematico;
            operadorMatematico = rnd.Next(1, 4);
            // gera um numero randomico de 1 a 4 para representar as operações matemáticas
            while (opcaoValida == false) {
                // Divisão
                if (operadorMatematico == 1 && dadosConfigurados.operacoesDeDivisao)
                {
                    lblOperacaoMatematica.Text = "/";
                    // gera os fatores a partir do 1 para evitar erro por divisão por zero
                    gerarFatoresOperacaoMatematicaDivisao();
                    // calcula o resultado
                    resultadoOperacao = fator / multiplicador;
                    preencherDadosMultiplicadorFatorTela();
                    opcaoValida = true;
                }
                // Multiplicação
                else if (operadorMatematico == 2 && dadosConfigurados.operacoesDeMultiplicacao)
                {
                    // gera os fatores para a operação matemática
                    gerarFatoresOperacaoMatematica();
                    lblOperacaoMatematica.Text = "X";
                    // calcula do resultado
                    resultadoOperacao = fator * multiplicador;
                    preencherDadosMultiplicadorFatorTela();
                    opcaoValida = true;
                }
                // Adição
                else if (operadorMatematico == 3 && dadosConfigurados.operacoesDeAdicao)
                {
                    // gera os fatores para a operação matemática
                    gerarFatoresOperacaoMatematica();
                    lblOperacaoMatematica.Text = "+";
                    // calcula do resultado
                    resultadoOperacao = fator + multiplicador;
                    preencherDadosMultiplicadorFatorTela();
                    break;
                }
                // Subtração
                else if(operadorMatematico == 4 && dadosConfigurados.operacoesDeSubtracao)
                {
                    // gera os fatores para a operação matemática
                    gerarFatoresOperacaoMatematica();
                    lblOperacaoMatematica.Text = "-";
                    // calcula do resultado
                    resultadoOperacao = fator - multiplicador;
                    preencherDadosMultiplicadorFatorTela();
                    opcaoValida = true;
                }
                operadorMatematico = rnd.Next(1, 4);
            }
        }

        public void LimparDadosTxtResultado()
        {
            txtResultado.Text = "";
            txtResultado.Focus();
        }
        private void txtResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                ValidarRespostaUsuario();
            }
        }

        public void PararJogo()
        {
            zerarVariaveis();
            txtResultado.ReadOnly = true;
            txtResultado.Enabled = false;
            timerDuracao.Enabled = false;
            timerDuracao.Dispose();
            setarTempo("00:00");
            LimparDadosTxtResultado();
        }

        public void zerarVariaveis()
        {
           fator = 0;
           multiplicador = 0;
           resultadoOperacao = 0;
           qtdAcertosUsuario = 0;
           qtdErrosUsuario = 0;
           setarMultiplicador("");
            setarFator("");
        }
        private void btnParar_Click(object sender, EventArgs e)
        {
            PararJogo();
        }


        private void formJogoTabuada_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                IniciarJogo();
            }
            else if (e.KeyCode == Keys.F3)
            {
                PararJogo();
            }
            else if (e.KeyCode == Keys.F4)
            {
                AbrirTelaConfiguracoes();
            }
        }

        private void btnIniciarJogo_Click(object sender, EventArgs e)
        {
            IniciarJogo();
        }

        private void timerDuracao_Tick(object sender, EventArgs e)
        {
            if (tempoTotalSegundos != 0 )
            {
                if (qtdSegundos == 0 & qtdMinutos > 0)
                {
                    qtdMinutos--;
                    qtdSegundos = 60;
                }
                qtdSegundos--;
                tempoTotalSegundos--;
                setarTempo(qtdMinutos.ToString() +':'+ qtdSegundos.ToString());
            }
            else
            {
                PararJogo();
            }
        }

        public void AbrirTelaConfiguracoes()
        {
            if (confirmarAberturaTelaConfiguracao())
            {
                PararJogo();
                FormConfiguracao frmConfiguracao = new FormConfiguracao(this);
                frmConfiguracao.ShowDialog();
            }
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            AbrirTelaConfiguracoes();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNomeTabuada_Click(object sender, EventArgs e)
        {

        }

        private void txtMultiplicador_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTempo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
