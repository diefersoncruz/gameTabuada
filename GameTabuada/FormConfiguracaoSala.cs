using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GameTabuada
{
    public partial class FormConfiguracaoSala : Form
    {

        formJogoTabuada frmTabuda;
        public FormConfiguracaoSala(formJogoTabuada frm)
        {
            InitializeComponent();
            frmTabuda = frm;
        }
    }
}
