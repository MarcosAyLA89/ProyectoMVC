using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{

    class Conexion
    {
        public string instanciaServidor()
        {
            string s = "";
            Microsoft.Win32.RegistryKey rk;
            rk = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server", false);

            String[] nServer = (String[])rk.GetValue("InstalledInstances");


            if (nServer.Length > 0)
            {
                if (nServer[0] == "MSSQLSERVER")
                    s = "localhost";

                else
                    s = "localhost\\" + nServer[0];
            }

            return s;
        }
    }
}
