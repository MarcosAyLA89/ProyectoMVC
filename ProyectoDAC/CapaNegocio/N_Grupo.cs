using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class N_Grupo
    {
        D_Grupo ObjetoDatos = new D_Grupo();
        public List<E_Grupo> ListandoGrupo()
        {
            return ObjetoDatos.ListarGrupos();
        }

    }
}
