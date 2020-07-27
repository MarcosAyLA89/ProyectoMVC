using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class N_Instructor
    {
        D_Instructor ObjetoDatos = new D_Instructor();

        public List<E_Instructor>ListandoInstructor(string buscar)
        {
            return ObjetoDatos.ListarInstructores(buscar);
        }

        public void InsertInstructor(E_Instructor Instructor)
        {

          ObjetoDatos.InsertInstructor(Instructor);
        }

        public void UpdatetInstructor(E_Instructor Instructor)
        {
            ObjetoDatos.UpdateInstructor(Instructor);
        }
        public void DeletetInstructor(E_Instructor Instructor)
        {
            ObjetoDatos.DeleteInstructor(Instructor);
        }
    }
}
