using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmDialog : Form
    {
        public FrmDialog(string mensaje)
        {
            InitializeComponent();
            LabelMessage.Text = mensaje;
        }

        private void FrmDialog_Load(object sender, EventArgs e)
        {
            FadeTransition.ShowAsyc(this);
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
