using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.Configuration;
using CapaEntidades;

namespace CapaDatos
{

    public class D_Grupo
    {
        SqlConnection cnn;
        string sCn;

        public D_Grupo()
        {
            ConexionBaseDatos instConn = new ConexionBaseDatos();
            string s = instConn.instanciaServidor();

            sCn = "server=" + s + ";" + "database = DATA_BASE_DAC;" + "Integrated Security = SSPI";
            cnn = new SqlConnection(sCn);

        }

        public List<E_Grupo> ListarGrupos()
        {
            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand("SP_MostrarGrupos", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cnn.Open();
            reader = cmd.ExecuteReader();

            List<E_Grupo> Listar = new List<E_Grupo>();

            while (reader.Read())
            {
                Listar.Add(new E_Grupo
                {
                    Idgrupo = reader.GetInt32(0),
                    Nombre = reader.GetString(1)
                });
            }
            cnn.Close();
            return Listar;
        }

    }
}
