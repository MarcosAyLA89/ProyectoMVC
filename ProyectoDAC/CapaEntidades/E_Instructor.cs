using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Instructor
    {
        private int idinstructor;
        private string nombres;
        private string apellidos;
        private string nombregrupo="";
        private int idgrupo;
        private string contacto;
        private string correo;

        public int Idinstructor
        {
          get
            {
                return idinstructor;
            }

            set
            {
                idinstructor = value;
            }
        }

        public string Nombres
        {
            get
            {
                return nombres;
            }

            set
            {
                nombres = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return apellidos;
            }

            set
            {
                apellidos = value;
            }
        }
        public string Nombregrupo
        {
            get
            {
                return nombregrupo;
            }

            set
            {
                nombregrupo = value;
            }
        }
        public int Idgrupo
        {
            get
            {
                return idgrupo;
            }

            set
            {
                idgrupo = value;
            }
        }

        public string Contacto
        {
            get
            {
                return contacto;
            }

            set
            {
                contacto = value;
            }
        }

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }
        }

      
    }
}
