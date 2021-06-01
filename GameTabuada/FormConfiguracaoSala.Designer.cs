
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbControlJogadores = new System.Windows.Forms.TabControl();
            this.tbJogadores = new System.Windows.Forms.TabPage();
            this.tbSalas = new System.Windows.Forms.TabPage();
            this.tbRodadas = new System.Windows.Forms.TabPage();
            this.tbControlJogadores.SuspendLayout();
            this.tbJogadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jogadores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tbJogadores.Controls.Add(this.label1);
            this.tbJogadores.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbJogadores.Location = new System.Drawing.Point(4, 34);
            this.tbJogadores.Name = "tbJogadores";
            this.tbJogadores.Padding = new System.Windows.Forms.Padding(3);
            this.tbJogadores.Size = new System.Drawing.Size(592, 362);
            this.tbJogadores.TabIndex = 0;
            this.tbJogadores.Text = "Jogadores";
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
            // FormConfiguracaoJogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(624, 421);
            this.Controls.Add(this.tbControlJogadores);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormConfiguracaoJogadores";
            this.Text = "Configurações Jogadores";
            this.tbControlJogadores.ResumeLayout(false);
            this.tbJogadores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbControlJogadores;
        private System.Windows.Forms.TabPage tbJogadores;
        private System.Windows.Forms.TabPage tbSalas;
        private System.Windows.Forms.TabPage tbRodadas;
    }
}