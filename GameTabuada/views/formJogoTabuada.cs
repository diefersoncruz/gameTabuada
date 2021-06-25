using GameTabuada.utils;
using GameTabuada.views;
using System;
using System.Collections.Generic;
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
        public string pFormTabuadaSalaJogo;
        public int pFormTabuadaNumeroRodadas;
        int rodadaAtual, jogadorAtual, numeroJogadores;

        ModelConfiguracoes dadosConfigurados;
        ModelJogadores modelJogadores =  new ModelJogadores();
        List<ModelJogadores> listaJogadores = new List<ModelJogadores>();
        Jogadores jogadores = new Jogadores();

        Configuracoes configuracoes;
        Utils fUteis = new Utils();

        public formJogoTabuada()
        {
            InitializeComponent();
            dadosConfigurados = new ModelConfiguracoes();
            configuracoes = new Configuracoes();
            carregarConfiguracoesJson();
        }
        public void carregarConfiguracoesJson()
        {
            dadosConfigurados = configuracoes.carregarConfiguracoesArquivoJson();
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

        public void iniciarCronometro()
        {
            timerDuracao.Start();
            timerDuracao.Enabled = true;
        }
        public Boolean confirmarInicioNovoJogo()
        {
            // valida se existe um jogo em andamento
            if (getJogoEmAndamento())
            {
                // valida o retorno do usuário
                if (fUteis.ConfirmarAcaoUsuario("Deseja Realmente iniciar um novo jogo ?"))
                {
                    return true;
                }
                else
                {
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
                // valida o retorno do usuário
                if (fUteis.ConfirmarAcaoUsuario("Deseja Realmente abrir a tela de configurações? Isso irá parar o jogo atual!"))
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

        private void carregarConfiguracoesIniciais()
        {
            FormOpcoesJogo frmOpcoes = new FormOpcoesJogo(this);
            frmOpcoes.ShowDialog();
        }

        public void carregarJogadoresSalaAtual()
        {
            // valida se foi informado sala de jogadores
            if (pFormTabuadaSalaJogo != "")
            {
                listaJogadores = jogadores.carregarListaJogadoresSala(pFormTabuadaSalaJogo);            
            }
            else
            {
                ModelJogadores jogador = new ModelJogadores();
                jogador.nomeJogador = "Jogador01";
                listaJogadores.Add(jogador);
            }
        }
        
        private string getNomeJogadorAtual()
        {
            return listaJogadores[jogadorAtual].nomeJogador;
        }

        public void pararCronometro()
        {
            timerDuracao.Dispose();
        }
        public void iniciarNovoJogo()
        {
            // validação é menor, por que o jogador atual é inicializado com 0
            if (jogadorAtual < numeroJogadores)
            {
                if (fUteis.ConfirmarAcaoUsuario( getNomeJogadorAtual() + " está preparado(a) ?"))
                {
                    carregarConfiguracoesJogo();
                    preencherLabelRodada();
                    preencherLabelJogadorAtual();
                    iniciarCronometro();
                    ZerarVariaveis();
                    setarQtdAcertos("0");
                    setarQtdErros("0");
                    LimparDadosTxtResultado();
                    GeradorGameMatematica();
                    txtResultado.ReadOnly = false;
                    txtResultado.Enabled = true;
                    txtResultado.Focus();
                }
                else
                {
                    if ((jogadorAtual == numeroJogadores - 1) && (rodadaAtual < pFormTabuadaNumeroRodadas))
                    {
                        if (fUteis.ConfirmarAcaoUsuario("Deseja iniciar uma nova rodada ?"))
                        {
                            IniciarNovaRodada();
                        }
                        else
                        {
                            pararJogo();
                        }
                    }
                    else
                    {
                        if (fUteis.ConfirmarAcaoUsuario("Deseja ir para próximo jogador ?"))
                        {
                            jogadorAtual += 1;
                            iniciarNovoJogo();
                        }
                        else
                        {
                            if (rodadaAtual < pFormTabuadaNumeroRodadas)
                            {
                                if (fUteis.ConfirmarAcaoUsuario("Deseja iniciar uma nova rodada ?"))
                                {
                                    IniciarNovaRodada();
                                }
                                else
                                {
                                    pararJogo();
                                }
                            }
                            else
                            {
                                pararJogo();
                            }
                        }
                    }
                }
            }
            else
            {
                IniciarNovaRodada();
            }
        }

        public void preencherLabelRodada()
        {
            lblRodada.Text = "Rodada " + rodadaAtual.ToString() + " de " + pFormTabuadaNumeroRodadas.ToString();
        }

        public void preencherLabelJogadorAtual()
        {
            if (numeroJogadores >= 1)
            {
                // preenche o primeiro jogador 
                lblNomeJogador.Text = getNomeJogadorAtual();
            }
        }

        public void iniciarRodadas()
        {
            carregarJogadoresSalaAtual();
            lblSala.Text = pFormTabuadaSalaJogo;
            numeroJogadores = listaJogadores.Count;
            jogadorAtual = 0;
            rodadaAtual = 1;
            // Inicia um novo jogo
            iniciarNovoJogo();
        }

        public void IniciarJogo()
        {   // valida se é será iniciado um novo jogo
            if (confirmarInicioNovoJogo())
            {
                carregarConfiguracoesIniciais();
                iniciarRodadas();
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

        public void pararJogo()
        {
            ZerarVariaveis();
            txtResultado.ReadOnly = true;
            txtResultado.Enabled = false;
            timerDuracao.Enabled = false;
            timerDuracao.Dispose();
            setarTempo("00:00");
            LimparDadosTxtResultado();
        }

        public bool RodadaFinal()
        {
            if (rodadaAtual == pFormTabuadaNumeroRodadas)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void IniciarNovaRodada()
        {
            if (RodadaFinal())
            {
                pararJogo();
            }
            else
            {
                fUteis.ExibirMensagemUsuario("Iniciando próxima rodada...");
                rodadaAtual += 1;
                jogadorAtual = 0;
                iniciarNovoJogo();
            }
        }

        public void ZerarVariaveis()
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
            pararJogo();
        }


        private void formJogoTabuada_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                IniciarJogo();
            }
            else if (e.KeyCode == Keys.F3)
            {
                pararJogo();
            }
            else if (e.KeyCode == Keys.F4)
            {
                AbrirTelaConfiguracoes();
            }
            else if (e.KeyCode == Keys.F7)
            {
                AbrirTelaConfiguracoesJogadores();
            }
        }

        private void btnIniciarJogo_Click(object sender, EventArgs e)
        {
            IniciarJogo();
        }

        public void AbrirTelaConfiguracoesJogadores()
        {
            if (confirmarAberturaTelaConfiguracao())
            {
                pararJogo();
                FormConfiguracaoSala frmConfiguracao = new FormConfiguracaoSala(this);
                frmConfiguracao.ShowDialog();
            }
        }


        public void AbrirTelaConfiguracoes()
        {
            if (confirmarAberturaTelaConfiguracao())
            {
                pararJogo();
                FormConfiguracao frmConfiguracao = new FormConfiguracao(this);
                frmConfiguracao.ShowDialog();
            }
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            AbrirTelaConfiguracoes();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirTelaConfiguracoesJogadores();
        }
        private void timerDuracao_Tick(object sender, EventArgs e)
        {
            if (tempoTotalSegundos != 0)
            {
                if (qtdSegundos == 0 & qtdMinutos > 0)
                {
                    qtdMinutos--;
                    qtdSegundos = 60;
                }
                qtdSegundos--;
                tempoTotalSegundos--;
                setarTempo(qtdMinutos.ToString() + ':' + qtdSegundos.ToString());
            }
            else
            {
                // adicionado -1 devido variável de jogadorAtual ser inicializada em 0
                if (jogadorAtual == numeroJogadores-1)
                {
                    pararCronometro();
                    IniciarNovaRodada();
                }
                else
                {
                    pararCronometro();
                    jogadorAtual += 1;
                    iniciarNovoJogo();
                }
            }
        }
    }
}
