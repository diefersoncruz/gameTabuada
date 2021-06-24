namespace GameTabuada
{
    partial class FormOpcoesJogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIniciarJogo = new System.Windows.Forms.Button();
            this.cbJogadorUnico = new System.Windows.Forms.CheckBox();
            this.cbSelecaoSalaJogo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroRodadas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIniciarJogo
            // 
            this.btnIniciarJogo.BackColor = System.Drawing.Color.White;
            this.btnIniciarJogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIniciarJogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciarJogo.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnIniciarJogo.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnIniciarJogo.Location = new System.Drawing.Point(80, 322);
            this.btnIniciarJogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIniciarJogo.Name = "btnIniciarJogo";
            this.btnIniciarJogo.Size = new System.Drawing.Size(357, 65);
            this.btnIniciarJogo.TabIndex = 1;
            this.btnIniciarJogo.Text = "Iniciar Jogo";
            this.btnIniciarJogo.UseVisualStyleBackColor = false;
            this.btnIniciarJogo.Click += new System.EventHandler(this.btnIniciarJogo_Click);
            // 
            // cbJogadorUnico
            // 
            this.cbJogadorUnico.AutoSize = true;
            this.cbJogadorUnico.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cbJogadorUnico.Location = new System.Drawing.Point(170, 41);
            this.cbJogadorUnico.Name = "cbJogadorUnico";
            this.cbJogadorUnico.Size = new System.Drawing.Size(194, 29);
            this.cbJogadorUnico.TabIndex = 2;
            this.cbJogadorUnico.Text = "Jogador Único";
            this.cbJogadorUnico.UseVisualStyleBackColor = true;
            this.cbJogadorUnico.CheckedChanged += new System.EventHandler(this.cbJogadorUnico_CheckedChanged);
            // 
            // cbSelecaoSalaJogo
            // 
            this.cbSelecaoSalaJogo.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cbSelecaoSalaJogo.FormattingEnabled = true;
            this.cbSelecaoSalaJogo.Location = new System.Drawing.Point(259, 123);
            this.cbSelecaoSalaJogo.Name = "cbSelecaoSalaJogo";
            this.cbSelecaoSalaJogo.Size = new System.Drawing.Size(178, 33);
            this.cbSelecaoSalaJogo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(80, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sala do Jogo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(80, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nº  Rodadas:";
            // 
            // txtNumeroRodadas
            // 
            this.txtNumeroRodadas.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtNumeroRodadas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNumeroRodadas.Location = new System.Drawing.Point(259, 188);
            this.txtNumeroRodadas.Name = "txtNumeroRodadas";
            this.txtNumeroRodadas.Size = new System.Drawing.Size(178, 32);
            this.txtNumeroRodadas.TabIndex = 6;
            this.txtNumeroRodadas.Text = "1";
            this.txtNumeroRodadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumeroRodadas.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumeroRodadas_Validating);
            // 
            // FormOpcoesJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(529, 424);
            this.Controls.Add(this.txtNumeroRodadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSelecaoSalaJogo);
            this.Controls.Add(this.cbJogadorUnico);
            this.Controls.Add(this.btnIniciarJogo);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormOpcoesJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações Iniciais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIniciarJogo;
        private System.Windows.Forms.CheckBox cbJogadorUnico;
        private System.Windows.Forms.ComboBox cbSelecaoSalaJogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroRodadas;
    }
}