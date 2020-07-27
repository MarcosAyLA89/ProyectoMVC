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
    public partial class FrmWarning : Form
    {
        public FrmWarning(string mensaje)
        {
            InitializeComponent();
            LabelMessage.Text = mensaje;
        }

        private void FrmWarning_Load(object sender, EventArgs e)
        {
            FadeTransition.ShowAsyc(this);
        }
        public static void WarningForm(string mensaje)
        {
            FrmWarning frm = new FrmWarning(mensaje);
            frm.ShowDialog();

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
