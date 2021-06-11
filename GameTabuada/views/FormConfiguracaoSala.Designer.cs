﻿
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
            this.cbSalaJogador = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluirJogador = new System.Windows.Forms.Button();
            this.dtJogadores = new System.Windows.Forms.DataGridView();
            this.dtJogadoresEditJogador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtJogadoresCBSala = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtJogador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvarJogador = new System.Windows.Forms.Button();
            this.tbSalas = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalvarSala = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.btnExcluirSala = new System.Windows.Forms.Button();
            this.dtSalas = new System.Windows.Forms.DataGridView();
            this.dtSalasEditSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbControlJogadores.SuspendLayout();
            this.tbJogadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtJogadores)).BeginInit();
            this.tbSalas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControlJogadores
            // 
            this.tbControlJogadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbControlJogadores.Controls.Add(this.tbJogadores);
            this.tbControlJogadores.Controls.Add(this.tbSalas);
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
            this.tbJogadores.Controls.Add(this.cbSalaJogador);
            this.tbJogadores.Controls.Add(this.label3);
            this.tbJogadores.Controls.Add(this.label1);
            this.tbJogadores.Controls.Add(this.btnExcluirJogador);
            this.tbJogadores.Controls.Add(this.dtJogadores);
            this.tbJogadores.Controls.Add(this.txtJogador);
            this.tbJogadores.Controls.Add(this.label2);
            this.tbJogadores.Controls.Add(this.btnSalvarJogador);
            this.tbJogadores.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbJogadores.Location = new System.Drawing.Point(4, 34);
            this.tbJogadores.Name = "tbJogadores";
            this.tbJogadores.Padding = new System.Windows.Forms.Padding(3);
            this.tbJogadores.Size = new System.Drawing.Size(592, 362);
            this.tbJogadores.TabIndex = 0;
            this.tbJogadores.Text = "Jogadores";
            // 
            // cbSalaJogador
            // 
            this.cbSalaJogador.FormattingEnabled = true;
            this.cbSalaJogador.Location = new System.Drawing.Point(147, 53);
            this.cbSalaJogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSalaJogador.Name = "cbSalaJogador";
            this.cbSalaJogador.Size = new System.Drawing.Size(169, 27);
            this.cbSalaJogador.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(17, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sala : ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(330, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "* Deve conter no máximo 11 caracteres *";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnExcluirJogador.Click += new System.EventHandler(this.btnExcluirJogador_Click);
            // 
            // dtJogadores
            // 
            this.dtJogadores.ColumnHeadersHeight = 30;
            this.dtJogadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtJogadoresEditJogador,
            this.dtJogadoresCBSala});
            this.dtJogadores.Location = new System.Drawing.Point(17, 99);
            this.dtJogadores.Name = "dtJogadores";
            this.dtJogadores.RowHeadersWidth = 50;
            this.dtJogadores.RowTemplate.Height = 30;
            this.dtJogadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtJogadores.Size = new System.Drawing.Size(404, 269);
            this.dtJogadores.TabIndex = 6;
            this.dtJogadores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtJogadores_CellClick);
            this.dtJogadores.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dtJogadores_KeyUp);
            // 
            // dtJogadoresEditJogador
            // 
            this.dtJogadoresEditJogador.HeaderText = "Jogador";
            this.dtJogadoresEditJogador.MaxInputLength = 11;
            this.dtJogadoresEditJogador.MinimumWidth = 6;
            this.dtJogadoresEditJogador.Name = "dtJogadoresEditJogador";
            this.dtJogadoresEditJogador.Width = 150;
            // 
            // dtJogadoresCBSala
            // 
            this.dtJogadoresCBSala.HeaderText = "Sala";
            this.dtJogadoresCBSala.MaxDropDownItems = 10;
            this.dtJogadoresCBSala.MinimumWidth = 6;
            this.dtJogadoresCBSala.Name = "dtJogadoresCBSala";
            this.dtJogadoresCBSala.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtJogadoresCBSala.Sorted = true;
            this.dtJogadoresCBSala.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dtJogadoresCBSala.Width = 200;
            // 
            // txtJogador
            // 
            this.txtJogador.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtJogador.Location = new System.Drawing.Point(147, 14);
            this.txtJogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJogador.MaxLength = 11;
            this.txtJogador.Name = "txtJogador";
            this.txtJogador.Size = new System.Drawing.Size(169, 32);
            this.txtJogador.TabIndex = 0;
            this.txtJogador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtJogador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtJogador_KeyUp);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(17, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jogador :";
            // 
            // btnSalvarJogador
            // 
            this.btnSalvarJogador.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarJogador.Location = new System.Drawing.Point(426, 134);
            this.btnSalvarJogador.Name = "btnSalvarJogador";
            this.btnSalvarJogador.Size = new System.Drawing.Size(139, 44);
            this.btnSalvarJogador.TabIndex = 2;
            this.btnSalvarJogador.Text = "Salvar";
            this.btnSalvarJogador.UseVisualStyleBackColor = true;
            this.btnSalvarJogador.Click += new System.EventHandler(this.btnSalvarJogadores_Click);
            // 
            // tbSalas
            // 
            this.tbSalas.BackColor = System.Drawing.Color.SkyBlue;
            this.tbSalas.Controls.Add(this.label6);
            this.tbSalas.Controls.Add(this.btnSalvarSala);
            this.tbSalas.Controls.Add(this.label5);
            this.tbSalas.Controls.Add(this.txtSala);
            this.tbSalas.Controls.Add(this.btnExcluirSala);
            this.tbSalas.Controls.Add(this.dtSalas);
            this.tbSalas.ForeColor = System.Drawing.Color.Black;
            this.tbSalas.Location = new System.Drawing.Point(4, 34);
            this.tbSalas.Name = "tbSalas";
            this.tbSalas.Padding = new System.Windows.Forms.Padding(3);
            this.tbSalas.Size = new System.Drawing.Size(592, 362);
            this.tbSalas.TabIndex = 1;
            this.tbSalas.Text = "Salas";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(18, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sala :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalvarSala
            // 
            this.btnSalvarSala.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarSala.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarSala.Location = new System.Drawing.Point(428, 127);
            this.btnSalvarSala.Name = "btnSalvarSala";
            this.btnSalvarSala.Size = new System.Drawing.Size(139, 44);
            this.btnSalvarSala.TabIndex = 11;
            this.btnSalvarSala.Text = "Salvar";
            this.btnSalvarSala.UseVisualStyleBackColor = true;
            this.btnSalvarSala.Click += new System.EventHandler(this.btnSalvarSala_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(332, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 30);
            this.label5.TabIndex = 16;
            this.label5.Text = "* Deve conter no máximo 11 caracteres *";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSala
            // 
            this.txtSala.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSala.Location = new System.Drawing.Point(148, 27);
            this.txtSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSala.MaxLength = 11;
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(169, 32);
            this.txtSala.TabIndex = 13;
            this.txtSala.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSala.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSala_KeyUp);
            // 
            // btnExcluirSala
            // 
            this.btnExcluirSala.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnExcluirSala.ForeColor = System.Drawing.Color.Black;
            this.btnExcluirSala.Location = new System.Drawing.Point(428, 215);
            this.btnExcluirSala.Name = "btnExcluirSala";
            this.btnExcluirSala.Size = new System.Drawing.Size(139, 44);
            this.btnExcluirSala.TabIndex = 15;
            this.btnExcluirSala.Text = "Excluir";
            this.btnExcluirSala.UseVisualStyleBackColor = true;
            this.btnExcluirSala.Click += new System.EventHandler(this.btnExcluirSala_Click);
            // 
            // dtSalas
            // 
            this.dtSalas.ColumnHeadersHeight = 29;
            this.dtSalas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtSalasEditSala});
            this.dtSalas.Location = new System.Drawing.Point(18, 67);
            this.dtSalas.Name = "dtSalas";
            this.dtSalas.RowHeadersWidth = 51;
            this.dtSalas.RowTemplate.Height = 25;
            this.dtSalas.Size = new System.Drawing.Size(404, 294);
            this.dtSalas.TabIndex = 14;
            this.dtSalas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dtSalas_KeyUp);
            // 
            // dtSalasEditSala
            // 
            this.dtSalasEditSala.HeaderText = "Sala";
            this.dtSalasEditSala.MaxInputLength = 11;
            this.dtSalasEditSala.MinimumWidth = 6;
            this.dtSalasEditSala.Name = "dtSalasEditSala";
            this.dtSalasEditSala.Width = 150;
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
            this.Shown += new System.EventHandler(this.FormConfiguracaoSala_Shown);
            this.tbControlJogadores.ResumeLayout(false);
            this.tbJogadores.ResumeLayout(false);
            this.tbJogadores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtJogadores)).EndInit();
            this.tbSalas.ResumeLayout(false);
            this.tbSalas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSalas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbControlJogadores;
        private System.Windows.Forms.TabPage tbJogadores;
        private System.Windows.Forms.TabPage tbSalas;
        private System.Windows.Forms.Button btnSalvarJogador;
        private System.Windows.Forms.DataGridView dtJogadores;
        private System.Windows.Forms.TextBox txtJogador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExcluirJogador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSalaJogador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalvarSala;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.Button btnExcluirSala;
        private System.Windows.Forms.DataGridView dtSalas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtSalasEditSala;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtJogadoresEditJogador;
        private System.Windows.Forms.DataGridViewComboBoxColumn dtJogadoresCBSala;
    }
}