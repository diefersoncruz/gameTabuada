using System.Windows.Forms;

namespace GameTabuada
{
    partial class formJogoTabuada
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public void setarNomeTabuada(string texto)
        {
            lblNomeTabuada.Text = texto;
        }

        public void setarFator(string texto)
        {
            txtFator.Text = texto;
        }

        public void setarMultiplicador(string texto)
        {
            txtMultiplicador.Text = texto;
        }

        public string getTxtResultado()
        {
            return txtResultado.Text;
        }

        public void setarQtdErros(string txt )
        {
            txtQtdErros.Text = txt;
        }
        public void setarQtdAcertos(string txt)
        {
            txtQtdAcertos.Text = txt;
        }

        public void setarTempo(string tempo)
        {
            txtTempo.Text = tempo;
        }
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formJogoTabuada));
            this.txtFator = new System.Windows.Forms.TextBox();
            this.lblOperacaoMatematica = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtMultiplicador = new System.Windows.Forms.TextBox();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.btnIniciarJogo = new System.Windows.Forms.Button();
            this.lblNomeTabuada = new System.Windows.Forms.Label();
            this.txtQtdErros = new System.Windows.Forms.TextBox();
            this.txtQtdAcertos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerDuracao = new System.Windows.Forms.Timer(this.components);
            this.btnParar = new System.Windows.Forms.Button();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pJogadores = new System.Windows.Forms.Panel();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblRodada = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.pJogadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFator
            // 
            this.txtFator.BackColor = System.Drawing.Color.White;
            this.txtFator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFator.CausesValidation = false;
            this.txtFator.Font = new System.Drawing.Font("Cooper Black", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtFator.ForeColor = System.Drawing.Color.Blue;
            this.txtFator.Location = new System.Drawing.Point(379, 136);
            this.txtFator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFator.Name = "txtFator";
            this.txtFator.ReadOnly = true;
            this.txtFator.Size = new System.Drawing.Size(228, 118);
            this.txtFator.TabIndex = 100;
            this.txtFator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOperacaoMatematica
            // 
            this.lblOperacaoMatematica.AutoSize = true;
            this.lblOperacaoMatematica.Font = new System.Drawing.Font("Cooper Black", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblOperacaoMatematica.ForeColor = System.Drawing.Color.Blue;
            this.lblOperacaoMatematica.Location = new System.Drawing.Point(612, 139);
            this.lblOperacaoMatematica.Name = "lblOperacaoMatematica";
            this.lblOperacaoMatematica.Size = new System.Drawing.Size(123, 110);
            this.lblOperacaoMatematica.TabIndex = 1;
            this.lblOperacaoMatematica.Text = "X";
            this.lblOperacaoMatematica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.White;
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultado.Font = new System.Drawing.Font("Cooper Black", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.ForeColor = System.Drawing.Color.Blue;
            this.txtResultado.Location = new System.Drawing.Point(486, 266);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(350, 118);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResultado_KeyPress);
            // 
            // txtMultiplicador
            // 
            this.txtMultiplicador.BackColor = System.Drawing.Color.White;
            this.txtMultiplicador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMultiplicador.CausesValidation = false;
            this.txtMultiplicador.Font = new System.Drawing.Font("Cooper Black", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtMultiplicador.ForeColor = System.Drawing.Color.Blue;
            this.txtMultiplicador.Location = new System.Drawing.Point(752, 136);
            this.txtMultiplicador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMultiplicador.Name = "txtMultiplicador";
            this.txtMultiplicador.ReadOnly = true;
            this.txtMultiplicador.Size = new System.Drawing.Size(219, 118);
            this.txtMultiplicador.TabIndex = 99;
            this.txtMultiplicador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMultiplicador.TextChanged += new System.EventHandler(this.txtMultiplicador_TextChanged);
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.BackColor = System.Drawing.Color.SkyBlue;
            this.btnConfiguracoes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfiguracoes.BackgroundImage")));
            this.btnConfiguracoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfiguracoes.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnConfiguracoes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnConfiguracoes.Location = new System.Drawing.Point(1031, -2);
            this.btnConfiguracoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(45, 32);
            this.btnConfiguracoes.TabIndex = 101;
            this.btnConfiguracoes.UseVisualStyleBackColor = false;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // btnIniciarJogo
            // 
            this.btnIniciarJogo.BackColor = System.Drawing.Color.White;
            this.btnIniciarJogo.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnIniciarJogo.ForeColor = System.Drawing.Color.Green;
            this.btnIniciarJogo.Location = new System.Drawing.Point(474, 404);
            this.btnIniciarJogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIniciarJogo.Name = "btnIniciarJogo";
            this.btnIniciarJogo.Size = new System.Drawing.Size(175, 60);
            this.btnIniciarJogo.TabIndex = 3;
            this.btnIniciarJogo.Text = "Iniciar Jogo (F2)";
            this.btnIniciarJogo.UseVisualStyleBackColor = false;
            this.btnIniciarJogo.Click += new System.EventHandler(this.btnIniciarJogo_Click);
            // 
            // lblNomeTabuada
            // 
            this.lblNomeTabuada.BackColor = System.Drawing.Color.SkyBlue;
            this.lblNomeTabuada.Font = new System.Drawing.Font("Cooper Black", 40F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblNomeTabuada.ForeColor = System.Drawing.Color.Blue;
            this.lblNomeTabuada.Location = new System.Drawing.Point(10, 21);
            this.lblNomeTabuada.Name = "lblNomeTabuada";
            this.lblNomeTabuada.Size = new System.Drawing.Size(1013, 95);
            this.lblNomeTabuada.TabIndex = 102;
            this.lblNomeTabuada.Text = "Matematicando";
            this.lblNomeTabuada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNomeTabuada.Click += new System.EventHandler(this.lblNomeTabuada_Click);
            // 
            // txtQtdErros
            // 
            this.txtQtdErros.BackColor = System.Drawing.Color.SkyBlue;
            this.txtQtdErros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQtdErros.Font = new System.Drawing.Font("Arial Black", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtQtdErros.ForeColor = System.Drawing.Color.Red;
            this.txtQtdErros.Location = new System.Drawing.Point(177, 178);
            this.txtQtdErros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQtdErros.Name = "txtQtdErros";
            this.txtQtdErros.ReadOnly = true;
            this.txtQtdErros.Size = new System.Drawing.Size(109, 36);
            this.txtQtdErros.TabIndex = 1;
            this.txtQtdErros.Text = "0";
            this.txtQtdErros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQtdAcertos
            // 
            this.txtQtdAcertos.BackColor = System.Drawing.Color.SkyBlue;
            this.txtQtdAcertos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQtdAcertos.Font = new System.Drawing.Font("Arial Black", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtQtdAcertos.ForeColor = System.Drawing.Color.Blue;
            this.txtQtdAcertos.Location = new System.Drawing.Point(177, 136);
            this.txtQtdAcertos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQtdAcertos.Name = "txtQtdAcertos";
            this.txtQtdAcertos.ReadOnly = true;
            this.txtQtdAcertos.Size = new System.Drawing.Size(109, 36);
            this.txtQtdAcertos.TabIndex = 1;
            this.txtQtdAcertos.Text = "0";
            this.txtQtdAcertos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(15, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Erros  : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(15, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Acertos : ";
            // 
            // timerDuracao
            // 
            this.timerDuracao.Interval = 1000;
            this.timerDuracao.Tick += new System.EventHandler(this.timerDuracao_Tick);
            // 
            // btnParar
            // 
            this.btnParar.BackColor = System.Drawing.Color.White;
            this.btnParar.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnParar.ForeColor = System.Drawing.Color.Red;
            this.btnParar.Location = new System.Drawing.Point(680, 404);
            this.btnParar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(175, 60);
            this.btnParar.TabIndex = 101;
            this.btnParar.Text = "Parar Jogo (F3)";
            this.btnParar.UseVisualStyleBackColor = false;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // txtTempo
            // 
            this.txtTempo.BackColor = System.Drawing.Color.Blue;
            this.txtTempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTempo.Font = new System.Drawing.Font("Arial Black", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTempo.ForeColor = System.Drawing.Color.White;
            this.txtTempo.Location = new System.Drawing.Point(76, 236);
            this.txtTempo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.ReadOnly = true;
            this.txtTempo.Size = new System.Drawing.Size(110, 43);
            this.txtTempo.TabIndex = 1;
            this.txtTempo.Text = "00:00";
            this.txtTempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTempo.TextChanged += new System.EventHandler(this.txtTempo_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(860, 23);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 85);
            this.panel2.TabIndex = 104;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(15, 23);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(98, 87);
            this.panel3.TabIndex = 105;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(899, 359);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(125, 100);
            this.panel4.TabIndex = 106;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(375, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(491, 42);
            this.label5.TabIndex = 107;
            this.label5.Text = "Desenvolvido por Dieferson da Silva Cruz  / E-mail: dieferson.cruz@outlook.com\r\n\r" +
    "\nÍcones retirados do site https://icons8.com.br";
            // 
            // pJogadores
            // 
            this.pJogadores.Controls.Add(this.label1);
            this.pJogadores.Location = new System.Drawing.Point(15, 296);
            this.pJogadores.Name = "pJogadores";
            this.pJogadores.Size = new System.Drawing.Size(350, 230);
            this.pJogadores.TabIndex = 108;
            // 
            // lblSala
            // 
            this.lblSala.BackColor = System.Drawing.Color.SkyBlue;
            this.lblSala.Font = new System.Drawing.Font("Cooper Black", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblSala.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSala.Location = new System.Drawing.Point(17, 300);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(340, 40);
            this.lblSala.TabIndex = 109;
            this.lblSala.Text = "5 Ano";
            this.lblSala.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblRodada
            // 
            this.lblRodada.BackColor = System.Drawing.Color.SkyBlue;
            this.lblRodada.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblRodada.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblRodada.ForeColor = System.Drawing.Color.Black;
            this.lblRodada.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblRodada.Location = new System.Drawing.Point(16, 350);
            this.lblRodada.Name = "lblRodada";
            this.lblRodada.Size = new System.Drawing.Size(340, 30);
            this.lblRodada.TabIndex = 110;
            this.lblRodada.Text = "Rodada 1 de 2";
            this.lblRodada.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(10, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 80);
            this.label1.TabIndex = 0;
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.BackColor = System.Drawing.Color.SkyBlue;
            this.lblNomeJogador.Font = new System.Drawing.Font("Cooper Black", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblNomeJogador.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblNomeJogador.Location = new System.Drawing.Point(100, 390);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(250, 70);
            this.lblNomeJogador.TabIndex = 111;
            this.lblNomeJogador.Text = "Dieferson";
            this.lblNomeJogador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.White;
            this.btnUsuarios.Font = new System.Drawing.Font("Cooper Black", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnUsuarios.ForeColor = System.Drawing.Color.Black;
            this.btnUsuarios.Location = new System.Drawing.Point(35, 490);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(300, 30);
            this.btnUsuarios.TabIndex = 112;
            this.btnUsuarios.Text = "Configurar sala (F7)";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // formJogoTabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1086, 541);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.lblRodada);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.pJogadores);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQtdAcertos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQtdErros);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.lblNomeTabuada);
            this.Controls.Add(this.btnIniciarJogo);
            this.Controls.Add(this.btnConfiguracoes);
            this.Controls.Add(this.txtMultiplicador);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblOperacaoMatematica);
            this.Controls.Add(this.txtFator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formJogoTabuada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabuada";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.formJogoTabuada_KeyUp);
            this.pJogadores.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFator;
        private System.Windows.Forms.Label lblOperacaoMatematica;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtMultiplicador;


        private Button btnConfiguracoes;
        private Button btnIniciarJogo;
        private Label lblNomeTabuada;
        private TextBox txtQtdErros;
        private TextBox txtQtdAcertos;
        private Label label4;
        private Label label3;
        private Timer timerDuracao;
        private Button btnParar;
        private TextBox txtTempo;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label5;
        private Panel pJogadores;
        private Label lblSala;
        private Label lblRodada;
        private Label label1;
        private Label lblNomeJogador;
        private Button btnUsuarios;
    }
}

