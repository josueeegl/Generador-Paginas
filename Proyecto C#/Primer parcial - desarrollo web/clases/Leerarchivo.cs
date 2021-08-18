using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_parcial___desarrollo_web.clases
{
    class Leerarchivo
    {
        public static string texto = "";
        public void leerarchivo(string archivo)
        {
            StreamReader reader = new StreamReader(archivo, System.Text.Encoding.Default);

            string texto2;
            texto2 = reader.ReadToEnd();
            reader.Close();
            texto = texto2;

        }
    }
}
