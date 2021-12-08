
namespace GameTabuada.views
{
    partial class FormMsg
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
            this.lblFormMsg = new System.Windows.Forms.Label();
            this.btnOkFormMsg = new System.Windows.Forms.Button();
            this.btnCancelFormMsg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFormMsg
            // 
            this.lblFormMsg.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblFormMsg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFormMsg.Location = new System.Drawing.Point(14, 12);
            this.lblFormMsg.Name = "lblFormMsg";
            this.lblFormMsg.Size = new System.Drawing.Size(480, 152);
            this.lblFormMsg.TabIndex = 3;
            this.lblFormMsg.Text = "Mensagem ao usuário";
            this.lblFormMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOkFormMsg
            // 
            this.btnOkFormMsg.BackColor = System.Drawing.Color.White;
            this.btnOkFormMsg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOkFormMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkFormMsg.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnOkFormMsg.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnOkFormMsg.Location = new System.Drawing.Point(272, 211);
            this.btnOkFormMsg.Name = "btnOkFormMsg";
            this.btnOkFormMsg.Size = new System.Drawing.Size(144, 51);
            this.btnOkFormMsg.TabIndex = 4;
            this.btnOkFormMsg.Text = "OK";
            this.btnOkFormMsg.UseVisualStyleBackColor = false;
            this.btnOkFormMsg.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancelFormMsg
            // 
            this.btnCancelFormMsg.BackColor = System.Drawing.Color.White;
            this.btnCancelFormMsg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelFormMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelFormMsg.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnCancelFormMsg.ForeColor = System.Drawing.Color.Red;
            this.btnCancelFormMsg.Location = new System.Drawing.Point(104, 211);
            this.btnCancelFormMsg.Name = "btnCancelFormMsg";
            this.btnCancelFormMsg.Size = new System.Drawing.Size(144, 51);
            this.btnCancelFormMsg.TabIndex = 5;
            this.btnCancelFormMsg.Text = "Cancelar";
            this.btnCancelFormMsg.UseVisualStyleBackColor = false;
            this.btnCancelFormMsg.Click += new System.EventHandler(this.btnCancelFormMsg_Click);
            // 
            // FormMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 274);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelFormMsg);
            this.Controls.Add(this.btnOkFormMsg);
            this.Controls.Add(this.lblFormMsg);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMsg";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblFormMsg;
        private System.Windows.Forms.Button btnOkFormMsg;
        private System.Windows.Forms.Button btnCancelFormMsg;
    }
}