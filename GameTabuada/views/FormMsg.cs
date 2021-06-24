using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GameTabuada.views
{
    public partial class FormMsg : Form
    {
        public FormMsg(string mensagem, string msgButtonOk = "OK", string msgButtonCancel = "Cancel", bool exibirButtonCancel = true)
        {
            InitializeComponent();
            lblFormMsg.Text = mensagem;
            btnOkFormMsg.Text = msgButtonOk;
            btnCancelFormMsg.Visible = exibirButtonCancel;
            btnCancelFormMsg.Text = msgButtonCancel;
            if (exibirButtonCancel == false)
            {
                btnOkFormMsg.Location =  new System.Drawing.Point(90, 100);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;        
        }

        private void btnCancelFormMsg_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
