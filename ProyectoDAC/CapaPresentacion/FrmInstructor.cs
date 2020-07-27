using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class FrmInstructor : Form
    {
        private int IdInstructor=0;
        private int IdGrupo = 0;

        List<string> NombresGrupos = new List<string>();
        List<int> IdGrupos = new List<int>();
        //Objeto tipo Instructor
        E_Instructor ObjetoEntidadInstructor = new E_Instructor();
        N_Instructor ObjetoNegocioInstructor = new N_Instructor();

        //Objeto tipo Grupo
        N_Grupo ObjetoNegocioGrupo = new N_Grupo();
        E_Grupo ObjetoEntidadGrupo = new E_Grupo();

        //Clase Verficaciones 
        Verificaciones verificar = new Verificaciones();
        public FrmInstructor()
        {
            InitializeComponent();
        }
        public void LlenarGrupos()
        {
            List<E_Grupo> Grupos = new List<E_Grupo>();
            Grupos= ObjetoNegocioGrupo.ListandoGrupo();
            for (int i=0;i<Grupos.Count;i++)
            {
                NombresGrupos.Add(Grupos.ElementAt(i).Nombre);
                IdGrupos.Add(Grupos.ElementAt(i).Idgrupo);
            }
            Grupocmbx.DataSource = NombresGrupos;
        }


        private void FrmInstructor_Load(object sender, EventArgs e)
        {
            MostrarBuscarTabla("");
            AccionesTabla();
            LlenarGrupos();

            ValidarCampoVacio(Nombretxt);
            ValidarCampoVacio(Apellidotxt);
            ValidarCampoVacio(contactotxt);
            ValidarCampoVacio(Correotxt);
        }
        public void AccionesTabla()
        {
            InstructoresData.Columns[0].Visible = false;
            InstructoresData.Columns[1].Width = 60;
            InstructoresData.Columns[2].Width = 60;
            InstructoresData.Columns[3].Width = 60;
            InstructoresData.Columns[4].Visible = false;
            InstructoresData.Columns[5].Visible = false;
            InstructoresData.Columns[6].Visible = false;
            InstructoresData.ClearSelection();
        

        }
        private void CerrarPic_MouseHover(object sender, EventArgs e)
        {
            CerrarPic.BackColor = Color.FromArgb(235, 250, 250);
        }

        private void CerrarPic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CerrarPic_MouseLeave(object sender, EventArgs e)
        {
            CerrarPic.BackColor = Color.Transparent;
        }

        

        private void BuscarPic_MouseHover(object sender, EventArgs e)
        {
           
            BuscarPic.BackColor = Color.FromArgb(153,255,255);
        }

        private void BuscarPic_MouseLeave(object sender, EventArgs e)
        {
            BuscarPic.BackColor = Color.Transparent;
        }


        public void MostrarBuscarTabla(string buscar)
        {
            N_Instructor ObjetoNegocio = new N_Instructor();
            InstructoresData.DataSource = ObjetoNegocio.ListandoInstructor(buscar);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (ContarErrores(this) == 0)
            {

                if (InstructoresData.SelectedRows.Count > 0)
            {

                DialogResult result = new DialogResult();
                FrmDialog frm = new FrmDialog("Modificar");
                result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {

                    try
                    {
                    ObjetoEntidadInstructor.Idinstructor = IdInstructor;
                    ObjetoEntidadInstructor.Nombres = Nombretxt.Text;
                    ObjetoEntidadInstructor.Apellidos = Apellidotxt.Text;
                    ObjetoEntidadInstructor.Idgrupo = IdGrupo;
                    ObjetoEntidadInstructor.Contacto = contactotxt.Text;
                    ObjetoEntidadInstructor.Correo = Correotxt.Text;

                    ObjetoNegocioInstructor.UpdatetInstructor(ObjetoEntidadInstructor);
                    FrmSuccess.ConfirmacionForm("Registro Modificado!");
                    Limpiar();
                    MostrarBuscarTabla("");
                    InstructoresData.ClearSelection();
                        }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

             }

            }
            else
            {
                    FrmWarning.WarningForm("Seleccione una fila para modificar");

            }

         }
            else
            {
                FrmWarning.WarningForm("Verificar errores");
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Grupocmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdGrupo = IdGrupos.ElementAt(Grupocmbx.SelectedIndex);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if(ContarErrores(this)==0)
            { 
            try
            {
                ObjetoEntidadInstructor.Nombres = Nombretxt.Text;
                ObjetoEntidadInstructor.Apellidos = Apellidotxt.Text;
                ObjetoEntidadInstructor.Idgrupo = IdGrupo;
                ObjetoEntidadInstructor.Contacto = contactotxt.Text;
                ObjetoEntidadInstructor.Correo = Correotxt.Text;
                ObjetoNegocioInstructor.InsertInstructor(ObjetoEntidadInstructor);
                FrmSuccess.ConfirmacionForm("Registro Guardado!");
                Limpiar();
                MostrarBuscarTabla("");
                    InstructoresData.ClearSelection();
                }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          }
            else
            {
                FrmWarning.WarningForm("Verificar errores");
               
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            if (IdInstructor!=0)
            {
                    

                        DialogResult result = new DialogResult();
                        FrmDialog frm = new FrmDialog("Eliminar");
                        result = frm.ShowDialog();

               if (result == DialogResult.OK)

                      {

                        try
                        {
                        ObjetoEntidadInstructor.Idinstructor = IdInstructor;
                        ObjetoNegocioInstructor.DeletetInstructor(ObjetoEntidadInstructor);
                        FrmSuccess.ConfirmacionForm("Registro Eliminado!");
                        Limpiar();
                        MostrarBuscarTabla("");
                        InstructoresData.ClearSelection();
                    }

                        catch (Exception ex)
                        {
                        MessageBox.Show("ERROR: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        }
                
            }
            else

            {
                FrmWarning.WarningForm("Seleccione un registro si desea eliminarlo");
               

            }
        }

        private void NuevoBtn_Click(object sender, EventArgs e)
        {
            Limpiar();
            InstructoresData.ClearSelection();
        }

        private void InstructoresData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (InstructoresData.SelectedRows.Count > 0)
            {
                IdInstructor = Convert.ToInt32(InstructoresData.CurrentRow.Cells[0].Value.ToString());
                Nombretxt.Text = InstructoresData.CurrentRow.Cells[1].Value.ToString();
                Apellidotxt.Text = InstructoresData.CurrentRow.Cells[2].Value.ToString();
                Grupocmbx.Text= InstructoresData.CurrentRow.Cells[3].Value.ToString();
                contactotxt.Text = InstructoresData.CurrentRow.Cells[5].Value.ToString();
                Correotxt.Text = InstructoresData.CurrentRow.Cells[6].Value.ToString();

            }
        }
        //EVENTOS TEXT CHANGED
        private void Nombretxt_TextChanged(object sender, EventArgs e)
        {
            ValidarCampoVacio(Nombretxt);
        }

        private void Apellidotxt_TextChanged(object sender, EventArgs e)
        {
            ValidarCampoVacio(Apellidotxt);
        }

        private void contactotxt_TextChanged(object sender, EventArgs e)
        {
            ValidarCampoVacio(contactotxt);
            FormatoNumero(contactotxt);
            if (verificar.VerificarNumero(contactotxt) == true)
            {
                ErrorProv.SetError(contactotxt, "");
            }
            else
            {

                ErrorProv.SetError(contactotxt, "Ingrese los 8 digitos");
            }

        }

        private void Correotxt_TextChanged(object sender, EventArgs e)
        {
            ValidarCampoVacio(Correotxt);
            if (verificar.RevisarCorreo(Correotxt) == true)
            {
                ErrorProv.SetError(Correotxt, "");
            }
            else
            {
                ErrorProv.SetError(Correotxt, "Ingrese el formato correcto");

            }

        }
        private void Buscartxt_TextChanged(object sender, EventArgs e)
        {
            MostrarBuscarTabla(Buscartxt.Text);
        }

        public void FormatoNumero(TextBox numero)
        {
            String contacto = numero.Text;
            int longitud = contacto.Length;
            if (longitud == 8)
            {
                if(contacto.Contains("-"))

                {

                }
                else
                {

                
                string parte1 = contacto.Substring(0, 4);
                string parte2 = contacto.Substring(4, 4);
                contacto = parte1 + "-" + parte2;
                numero.Text = contacto;
                }
            }
            else
            {

            }
        }
        private void contactotxt_KeyUp(object sender, KeyEventArgs e)
        {
            
        }


        //EVENTOS KEY PRESS
        private void Nombretxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsNumber(e.KeyChar))
            {

                e.Handled = true;

                if (e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }
            }

        }

        private void Apellidotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsNumber(e.KeyChar))
            {

                e.Handled = true;

                if (e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }
            }

        }
        private void contactotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || contactotxt.Text.Length >= 8)
            {

                e.Handled = true;

                if (e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }
                if(contactotxt.Text.Contains("-") && contactotxt.Text.Length==8)
                {
                    e.Handled = false;
                }
            }

        }


        private void Grupocmbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar)  || char.IsLetterOrDigit(e.KeyChar))
            {

                e.Handled = true;

                if (e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }
            }

        }

        public void ValidarCampoVacio(TextBox caja)
        {
            if (caja.Text.Length == 0)
            {
                ErrorProv.SetError(caja, "Campo requerido");
            }
            else
            {
                ErrorProv.SetError(caja, "");
            }
        }

        public int ContarErrores(Form formulario)
        {
            int total = 0;
            foreach (Control controles in formulario.Controls)
            {
                if (controles is TextBox)
                {
                    if (ErrorProv.GetError(controles).Length > 0)
                    {
                        total++;
                    }
                    else
                    {

                    }
                }

            }
            return total;
        }


        public void Limpiar()

        {

            Nombretxt.Clear();
            Apellidotxt.Clear();
            Grupocmbx.Refresh();
            contactotxt.Clear();
            Correotxt.Clear();

        }




    }
}
