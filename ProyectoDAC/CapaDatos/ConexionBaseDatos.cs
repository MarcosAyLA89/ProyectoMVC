using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    class ConexionBaseDatos
    {
        public static string MiServidor;
        public static string usuario, clave, db;
        public static string servidor;
        public static string cadena, conexionN;


        public static void conec()
        {
            servidor = MiServidor;
            db = "DATA_BASE_DAC";
            conexionN = "true";
            cadena = "server=" + ConexionBaseDatos.MiServidor + ";" +
                "database=master;integrated security=yes;";
        }


        //creando cadena de conexion
        public static IEnumerable<string> ListLocalSqlInstances()
        {
            if (Environment.Is64BitOperatingSystem)
            {
                using (var hive = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
                {
                    foreach (string item in ListLocalSqlInstances(hive))
                    {
                        yield return item;
                    }
                }

                using (var hive = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32))
                {
                    foreach (string item in ListLocalSqlInstances(hive))
                    {
                        yield return item;
                    }
                }
            }
            else
            {
                foreach (string item in ListLocalSqlInstances(Registry.LocalMachine))
                {
                    yield return item;
                }
            }
        }

        private static IEnumerable<string> ListLocalSqlInstances(RegistryKey hive)
        {
            const string keyName = @"Software\Microsoft\Microsoft SQL Server";
            const string valueName = "InstalledInstances";
            const string defaultName = "MSSQLSERVER";

            using (var key = hive.OpenSubKey(keyName, false))
            {
                if (key == null) return Enumerable.Empty<string>();

                var value = key.GetValue(valueName) as string[];
                if (value == null) return Enumerable.Empty<string>();

                for (int index = 0; index < value.Length; index++)
                {
                    if (string.Equals(value[index], defaultName, StringComparison.OrdinalIgnoreCase))
                    {
                        value[index] = ".";
                    }
                    else
                    {
                        value[index] = @".\" + value[index];
                    }
                }

                return value;
            }

        }


        public string instanciaServidor()
        {
            string s = "";



            IEnumerable<string> instancias = ListLocalSqlInstances();



            if (instancias != null)
            {

                s = instancias.LastOrDefault();

            }

            else

            {
                MessageBox.Show("NO SE PUEDE :c");

            }









            return s;
        }


        public void obtenerServidor()
        {
            string s = "";



            IEnumerable<string> instancias = ListLocalSqlInstances();



            if (instancias != null)
            {

                s = instancias.LastOrDefault();

            }

            else

            {
                MessageBox.Show("No se puede encontrar el servidor");

            }



            servidor = s;
        }



    }
}
