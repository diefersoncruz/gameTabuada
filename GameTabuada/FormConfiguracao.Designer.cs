namespace GameTabuada
{
    partial class FormConfiguracao
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
            this.btnSalvarConfiguracoes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfigLimiteFatorA = new System.Windows.Forms.TextBox();
            this.txtConfigLimiteFatorB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQtdMinutos = new System.Windows.Forms.TextBox();
            this.txtQtdSegundos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConfigLimiteNegativoFatorA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConfigLimiteNegativoFatorB = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbAdicao = new System.Windows.Forms.CheckBox();
            this.cbSubtracao = new System.Windows.Forms.CheckBox();
            this.cbMultiplicacao = new System.Windows.Forms.CheckBox();
            this.cbDivisao = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configurações";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalvarConfiguracoes
            // 
            this.btnSalvarConfiguracoes.BackColor = System.Drawing.Color.White;
            this.btnSalvarConfiguracoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvarConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarConfiguracoes.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarConfiguracoes.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSalvarConfiguracoes.Location = new System.Drawing.Point(187, 470);
            this.btnSalvarConfiguracoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvarConfiguracoes.Name = "btnSalvarConfiguracoes";
            this.btnSalvarConfiguracoes.Size = new System.Drawing.Size(295, 65);
            this.btnSalvarConfiguracoes.TabIndex = 1;
            this.btnSalvarConfiguracoes.Text = "Salvar (F8)";
            this.btnSalvarConfiguracoes.UseVisualStyleBackColor = false;
            this.btnSalvarConfiguracoes.Click += new System.EventHandler(this.btnSalvarConfiguracoes_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(10, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Limite Fator A :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(10, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Limite Fator B :";
            // 
            // txtConfigLimiteFatorA
            // 
            this.txtConfigLimiteFatorA.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfigLimiteFatorA.Location = new System.Drawing.Point(338, 56);
            this.txtConfigLimiteFatorA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfigLimiteFatorA.Name = "txtConfigLimiteFatorA";
            this.txtConfigLimiteFatorA.Size = new System.Drawing.Size(110, 32);
            this.txtConfigLimiteFatorA.TabIndex = 3;
            this.txtConfigLimiteFatorA.Text = "10";
            this.txtConfigLimiteFatorA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtConfigLimiteFatorB
            // 
            this.txtConfigLimiteFatorB.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfigLimiteFatorB.Location = new System.Drawing.Point(338, 90);
            this.txtConfigLimiteFatorB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfigLimiteFatorB.Name = "txtConfigLimiteFatorB";
            this.txtConfigLimiteFatorB.Size = new System.Drawing.Size(110, 32);
            this.txtConfigLimiteFatorB.TabIndex = 3;
            this.txtConfigLimiteFatorB.Text = "10";
            this.txtConfigLimiteFatorB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(9, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(384, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Configuração Cronômetro:";
            // 
            // txtQtdMinutos
            // 
            this.txtQtdMinutos.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQtdMinutos.Location = new System.Drawing.Point(176, 40);
            this.txtQtdMinutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQtdMinutos.Name = "txtQtdMinutos";
            this.txtQtdMinutos.Size = new System.Drawing.Size(69, 32);
            this.txtQtdMinutos.TabIndex = 3;
            this.txtQtdMinutos.Text = "1";
            this.txtQtdMinutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQtdSegundos
            // 
            this.txtQtdSegundos.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQtdSegundos.Location = new System.Drawing.Point(176, 74);
            this.txtQtdSegundos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQtdSegundos.Name = "txtQtdSegundos";
            this.txtQtdSegundos.Size = new System.Drawing.Size(69, 32);
            this.txtQtdSegundos.TabIndex = 3;
            this.txtQtdSegundos.Text = "5";
            this.txtQtdSegundos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(9, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Qtd Minutos:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtQtdSegundos);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtQtdMinutos);
            this.panel1.Location = new System.Drawing.Point(11, 155);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 112);
            this.panel1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(9, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Qtd Segundos:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(304, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "a";
            // 
            // txtConfigLimiteNegativoFatorA
            // 
            this.txtConfigLimiteNegativoFatorA.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfigLimiteNegativoFatorA.Location = new System.Drawing.Point(189, 57);
            this.txtConfigLimiteNegativoFatorA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfigLimiteNegativoFatorA.Name = "txtConfigLimiteNegativoFatorA";
            this.txtConfigLimiteNegativoFatorA.Size = new System.Drawing.Size(110, 32);
            this.txtConfigLimiteNegativoFatorA.TabIndex = 3;
            this.txtConfigLimiteNegativoFatorA.Text = "10";
            this.txtConfigLimiteNegativoFatorA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(304, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "a";
            // 
            // txtConfigLimiteNegativoFatorB
            // 
            this.txtConfigLimiteNegativoFatorB.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfigLimiteNegativoFatorB.Location = new System.Drawing.Point(190, 90);
            this.txtConfigLimiteNegativoFatorB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfigLimiteNegativoFatorB.Name = "txtConfigLimiteNegativoFatorB";
            this.txtConfigLimiteNegativoFatorB.Size = new System.Drawing.Size(110, 32);
            this.txtConfigLimiteNegativoFatorB.TabIndex = 3;
            this.txtConfigLimiteNegativoFatorB.Text = "10";
            this.txtConfigLimiteNegativoFatorB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbAdicao);
            this.panel2.Controls.Add(this.cbSubtracao);
            this.panel2.Controls.Add(this.cbMultiplicacao);
            this.panel2.Controls.Add(this.cbDivisao);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(13, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 153);
            this.panel2.TabIndex = 6;
            // 
            // cbAdicao
            // 
            this.cbAdicao.AutoSize = true;
            this.cbAdicao.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cbAdicao.Location = new System.Drawing.Point(263, 63);
            this.cbAdicao.Name = "cbAdicao";
            this.cbAdicao.Size = new System.Drawing.Size(96, 25);
            this.cbAdicao.TabIndex = 3;
            this.cbAdicao.Text = "Adição";
            this.cbAdicao.UseVisualStyleBackColor = true;
            // 
            // cbSubtracao
            // 
            this.cbSubtracao.AutoSize = true;
            this.cbSubtracao.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cbSubtracao.Location = new System.Drawing.Point(263, 94);
            this.cbSubtracao.Name = "cbSubtracao";
            this.cbSubtracao.Size = new System.Drawing.Size(128, 25);
            this.cbSubtracao.TabIndex = 3;
            this.cbSubtracao.Text = "Subtração";
            this.cbSubtracao.UseVisualStyleBackColor = true;
            // 
            // cbMultiplicacao
            // 
            this.cbMultiplicacao.AutoSize = true;
            this.cbMultiplicacao.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cbMultiplicacao.Location = new System.Drawing.Point(16, 94);
            this.cbMultiplicacao.Name = "cbMultiplicacao";
            this.cbMultiplicacao.Size = new System.Drawing.Size(162, 25);
            this.cbMultiplicacao.TabIndex = 3;
            this.cbMultiplicacao.Text = "Multiplicação";
            this.cbMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // cbDivisao
            // 
            this.cbDivisao.AutoSize = true;
            this.cbDivisao.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cbDivisao.Location = new System.Drawing.Point(16, 63);
            this.cbDivisao.Name = "cbDivisao";
            this.cbDivisao.Size = new System.Drawing.Size(101, 25);
            this.cbDivisao.TabIndex = 3;
            this.cbDivisao.Text = "Divisão";
            this.cbDivisao.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(7, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(384, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Operações Matemáticas:";
            // 
            // FormConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(741, 582);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtConfigLimiteNegativoFatorB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtConfigLimiteNegativoFatorA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtConfigLimiteFatorB);
            this.Controls.Add(this.txtConfigLimiteFatorA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalvarConfiguracoes);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormConfiguracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConfiguracao";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormConfiguracao_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvarConfiguracoes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfigLimiteFatorA;
        private System.Windows.Forms.TextBox txtConfigLimiteFatorB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQtdMinutos;
        private System.Windows.Forms.TextBox txtQtdSegundos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtConfigLimiteNegativoFatorA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConfigLimiteNegativoFatorB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbDivisao;
        private System.Windows.Forms.CheckBox cbAdicao;
        private System.Windows.Forms.CheckBox cbSubtracao;
        private System.Windows.Forms.CheckBox cbMultiplicacao;
    }
}