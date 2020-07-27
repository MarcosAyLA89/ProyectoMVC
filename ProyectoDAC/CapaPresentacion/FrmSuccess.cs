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
    public partial class FrmSuccess : Form
    {
        public FrmSuccess(string mensaje)
        {
            InitializeComponent();
            LabelMessage.Text = mensaje;
        }

        private void FrmSuccess_Load(object sender, EventArgs e)
        {
            FadeTransition.ShowAsyc(this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public static void ConfirmacionForm(string mensaje)
        {
            FrmSuccess frm = new FrmSuccess(mensaje);
            frm.ShowDialog();

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LabelMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
