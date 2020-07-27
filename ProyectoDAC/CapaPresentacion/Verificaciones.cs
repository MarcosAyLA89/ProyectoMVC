using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace CapaPresentacion
{
    public class Verificaciones
    {
        public bool RevisarCorreo(TextBox correo)
        {

            string mail = correo.Text;
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            Regex automata = new Regex(expresion);
            bool resultado = automata.IsMatch(mail);
            return resultado;
        }

       

        public bool VerificarNumero(TextBox numero)
        {
            bool resultado = false;
            int longitud = numero.Text.Length;
            if (longitud > 0)
            {
                if (longitud == 9)

                {
                    string[] letras = numero.Text.Split('-');
                    if (letras.Count() == 2)
                    {



                        string parte1 = numero.Text.Substring(0, 4);
                        string parte2 = numero.Text.Substring(5, 4);

                        int numero1 = 0;
                        int numero2 = 0;
                        int.TryParse(parte1, out numero1);
                        int.TryParse(parte1, out numero2);
                        if (numero1 != 0 && numero2 != 0)
                        {

                            resultado = true;
                        }

                    }

                }

                else
                {
                    resultado = false;
                }

            }

            return resultado;

        }

    }
}
