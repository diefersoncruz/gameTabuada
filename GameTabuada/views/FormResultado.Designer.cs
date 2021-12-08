
namespace GameTabuada
{
    partial class FormResultado
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
            this.dtResultado = new System.Windows.Forms.DataGridView();
            this.SALA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtJogadoresEditJogador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PONTUACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecarregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // dtResultado
            // 
            this.dtResultado.ColumnHeadersHeight = 30;
            this.dtResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SALA,
            this.dtJogadoresEditJogador,
            this.PONTUACAO});
            this.dtResultado.Location = new System.Drawing.Point(38, 54);
            this.dtResultado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtResultado.Name = "dtResultado";
            this.dtResultado.RowHeadersWidth = 50;
            this.dtResultado.RowTemplate.Height = 30;
            this.dtResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtResultado.Size = new System.Drawing.Size(456, 454);
            this.dtResultado.TabIndex = 7;
            // 
            // SALA
            // 
            this.SALA.HeaderText = "Sala";
            this.SALA.MinimumWidth = 6;
            this.SALA.Name = "SALA";
            this.SALA.ReadOnly = true;
            this.SALA.Width = 125;
            // 
            // dtJogadoresEditJogador
            // 
            this.dtJogadoresEditJogador.HeaderText = "Jogador";
            this.dtJogadoresEditJogador.MaxInputLength = 30;
            this.dtJogadoresEditJogador.MinimumWidth = 6;
            this.dtJogadoresEditJogador.Name = "dtJogadoresEditJogador";
            this.dtJogadoresEditJogador.ReadOnly = true;
            this.dtJogadoresEditJogador.Width = 150;
            // 
            // PONTUACAO
            // 
            this.PONTUACAO.HeaderText = "Pontuação";
            this.PONTUACAO.MinimumWidth = 6;
            this.PONTUACAO.Name = "PONTUACAO";
            this.PONTUACAO.ReadOnly = true;
            this.PONTUACAO.Width = 125;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "Resultados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnRecarregar.Location = new System.Drawing.Point(134, 516);
            this.btnRecarregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.Size = new System.Drawing.Size(254, 39);
            this.btnRecarregar.TabIndex = 9;
            this.btnRecarregar.Text = "Recarregar";
            this.btnRecarregar.UseVisualStyleBackColor = true;
            this.btnRecarregar.Click += new System.EventHandler(this.btnRecarregar_Click);
            // 
            // FormResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(653, 561);
            this.Controls.Add(this.btnRecarregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtResultado);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações Jogadores";
            ((System.ComponentModel.ISupportInitialize)(this.dtResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtJogadoresEditJogador;
        private System.Windows.Forms.DataGridViewTextBoxColumn PONTUACAO;
        private System.Windows.Forms.Button btnRecarregar;
    }
}