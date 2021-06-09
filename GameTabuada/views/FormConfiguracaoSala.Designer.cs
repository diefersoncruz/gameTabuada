
namespace GameTabuada
{
    partial class FormConfiguracaoSala
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
            this.tbControlJogadores = new System.Windows.Forms.TabControl();
            this.tbJogadores = new System.Windows.Forms.TabPage();
            this.btnExcluirJogador = new System.Windows.Forms.Button();
            this.dtJogadores = new System.Windows.Forms.DataGridView();
            this.jogador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sala = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtJogador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvarJogadores = new System.Windows.Forms.Button();
            this.tbSalas = new System.Windows.Forms.TabPage();
            this.tbRodadas = new System.Windows.Forms.TabPage();
            this.tbControlJogadores.SuspendLayout();
            this.tbJogadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtJogadores)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControlJogadores
            // 
            this.tbControlJogadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbControlJogadores.Controls.Add(this.tbJogadores);
            this.tbControlJogadores.Controls.Add(this.tbSalas);
            this.tbControlJogadores.Controls.Add(this.tbRodadas);
            this.tbControlJogadores.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbControlJogadores.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbControlJogadores.ItemSize = new System.Drawing.Size(150, 30);
            this.tbControlJogadores.Location = new System.Drawing.Point(12, 12);
            this.tbControlJogadores.Name = "tbControlJogadores";
            this.tbControlJogadores.SelectedIndex = 0;
            this.tbControlJogadores.Size = new System.Drawing.Size(600, 400);
            this.tbControlJogadores.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbControlJogadores.TabIndex = 1;
            // 
            // tbJogadores
            // 
            this.tbJogadores.BackColor = System.Drawing.Color.SkyBlue;
            this.tbJogadores.Controls.Add(this.btnExcluirJogador);
            this.tbJogadores.Controls.Add(this.dtJogadores);
            this.tbJogadores.Controls.Add(this.txtJogador);
            this.tbJogadores.Controls.Add(this.label2);
            this.tbJogadores.Controls.Add(this.btnSalvarJogadores);
            this.tbJogadores.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbJogadores.Location = new System.Drawing.Point(4, 34);
            this.tbJogadores.Name = "tbJogadores";
            this.tbJogadores.Padding = new System.Windows.Forms.Padding(3);
            this.tbJogadores.Size = new System.Drawing.Size(592, 362);
            this.tbJogadores.TabIndex = 0;
            this.tbJogadores.Text = "Jogadores";
            // 
            // btnExcluirJogador
            // 
            this.btnExcluirJogador.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnExcluirJogador.Location = new System.Drawing.Point(426, 223);
            this.btnExcluirJogador.Name = "btnExcluirJogador";
            this.btnExcluirJogador.Size = new System.Drawing.Size(139, 44);
            this.btnExcluirJogador.TabIndex = 7;
            this.btnExcluirJogador.Text = "Excluir";
            this.btnExcluirJogador.UseVisualStyleBackColor = true;
            // 
            // dtJogadores
            // 
            this.dtJogadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtJogadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jogador,
            this.sala});
            this.dtJogadores.Location = new System.Drawing.Point(16, 79);
            this.dtJogadores.Name = "dtJogadores";
            this.dtJogadores.RowTemplate.Height = 25;
            this.dtJogadores.Size = new System.Drawing.Size(404, 269);
            this.dtJogadores.TabIndex = 6;
            // 
            // jogador
            // 
            this.jogador.HeaderText = "Jogador";
            this.jogador.MaxInputLength = 11;
            this.jogador.Name = "jogador";
            this.jogador.Width = 150;
            // 
            // sala
            // 
            this.sala.HeaderText = "Sala";
            this.sala.Name = "sala";
            this.sala.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sala.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sala.Width = 200;
            // 
            // txtJogador
            // 
            this.txtJogador.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtJogador.Location = new System.Drawing.Point(147, 24);
            this.txtJogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJogador.Name = "txtJogador";
            this.txtJogador.Size = new System.Drawing.Size(178, 32);
            this.txtJogador.TabIndex = 5;
            this.txtJogador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(3, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jogador :";
            // 
            // btnSalvarJogadores
            // 
            this.btnSalvarJogadores.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarJogadores.Location = new System.Drawing.Point(426, 134);
            this.btnSalvarJogadores.Name = "btnSalvarJogadores";
            this.btnSalvarJogadores.Size = new System.Drawing.Size(139, 44);
            this.btnSalvarJogadores.TabIndex = 2;
            this.btnSalvarJogadores.Text = "Salvar";
            this.btnSalvarJogadores.UseVisualStyleBackColor = true;
            this.btnSalvarJogadores.Click += new System.EventHandler(this.btnSalvarJogadores_Click);
            // 
            // tbSalas
            // 
            this.tbSalas.BackColor = System.Drawing.Color.SkyBlue;
            this.tbSalas.ForeColor = System.Drawing.Color.Maroon;
            this.tbSalas.Location = new System.Drawing.Point(4, 34);
            this.tbSalas.Name = "tbSalas";
            this.tbSalas.Padding = new System.Windows.Forms.Padding(3);
            this.tbSalas.Size = new System.Drawing.Size(592, 362);
            this.tbSalas.TabIndex = 1;
            this.tbSalas.Text = "Salas";
            // 
            // tbRodadas
            // 
            this.tbRodadas.BackColor = System.Drawing.Color.SkyBlue;
            this.tbRodadas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbRodadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRodadas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbRodadas.Location = new System.Drawing.Point(4, 34);
            this.tbRodadas.Name = "tbRodadas";
            this.tbRodadas.Padding = new System.Windows.Forms.Padding(3);
            this.tbRodadas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbRodadas.Size = new System.Drawing.Size(592, 362);
            this.tbRodadas.TabIndex = 2;
            this.tbRodadas.Text = "Rodadas";
            // 
            // FormConfiguracaoSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(624, 421);
            this.Controls.Add(this.tbControlJogadores);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormConfiguracaoSala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações Jogadores";
            this.tbControlJogadores.ResumeLayout(false);
            this.tbJogadores.ResumeLayout(false);
            this.tbJogadores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtJogadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbControlJogadores;
        private System.Windows.Forms.TabPage tbJogadores;
        private System.Windows.Forms.TabPage tbSalas;
        private System.Windows.Forms.TabPage tbRodadas;
        private System.Windows.Forms.Button btnSalvarJogadores;
        private System.Windows.Forms.DataGridView dtJogadores;
        private System.Windows.Forms.TextBox txtJogador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExcluirJogador;
        private System.Windows.Forms.DataGridViewTextBoxColumn jogador;
        private System.Windows.Forms.DataGridViewComboBoxColumn sala;
    }
}