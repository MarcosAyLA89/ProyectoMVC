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
using System.Windows.Forms;
namespace CapaDatos
{
    public class D_Instructor
    {
        
        //Comandos Para conexion
        SqlConnection cnn;
        string sCn;
        
        public D_Instructor()
        {
            ConexionBaseDatos instConn = new ConexionBaseDatos();
            string s = instConn.instanciaServidor();

            sCn = "server=" + s + ";" + "database = DATA_BASE_DAC;" + "Integrated Security = SSPI";
            cnn = new SqlConnection(sCn);

        }

        public List<E_Instructor>ListarInstructores(string buscar)
        {
            cnn.Open();
            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand("BuscarInstructor",cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Buscar", buscar);
            reader = cmd.ExecuteReader();

            List<E_Instructor> Listar = new List<E_Instructor>();

            while(reader.Read())
            {
                Listar.Add(new E_Instructor
                {
                    Idinstructor = reader.GetInt32(0),
                    Nombres = reader.GetString(1),
                    Apellidos = reader.GetString(2),
                    Nombregrupo=reader.GetString(3),
                    Idgrupo = reader.GetInt32(4),
                    Contacto=reader.GetString(5),
                    Correo=reader.GetString(6)
            
                
                });
            }
            reader.Close();
            cnn.Close();
            return Listar;
        }

        public void InsertInstructor(E_Instructor Instructor)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertInstructor", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cnn.Open();
            cmd.Parameters.AddWithValue("@Nombres", Instructor.Nombres);
            cmd.Parameters.AddWithValue("@Apellidos", Instructor.Apellidos);
            cmd.Parameters.AddWithValue("@IdGrupo", Instructor.Idgrupo);
            cmd.Parameters.AddWithValue("@Contacto", Instructor.Contacto);
            cmd.Parameters.AddWithValue("@Correo", Instructor.Correo);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public void UpdateInstructor(E_Instructor Instructor)
        {
            
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_UpdateInstructor", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdInstructor", Instructor.Idinstructor);
                cmd.Parameters.AddWithValue("@Nombres", Instructor.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", Instructor.Apellidos);
                cmd.Parameters.AddWithValue("@IdGrupo", Instructor.Idgrupo);
                cmd.Parameters.AddWithValue("@Contacto", Instructor.Contacto);
                cmd.Parameters.AddWithValue("@Correo", Instructor.Correo);
                cmd.ExecuteNonQuery();
                cnn.Close();
            
        }

        public void DeleteInstructor(E_Instructor Instructor)
        {
            SqlCommand cmd = new SqlCommand("SP_DeleteInstructor", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cnn.Open();
            cmd.Parameters.AddWithValue("@IdInstructor", Instructor.Idinstructor);
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
    }
    
}
