using Primer_parcial___desarrollo_web.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Primer_parcial___desarrollo_web.clases
{
    class generar_css
    {
        public static string path2 = "..\\..\\Resources\\css.css";
        public void guardar_en_carpeta(string path)//Aca guardaremos el html inicial, ubicacion = plantilla
        {
            if (File.Exists(path))
            {
                string filename = Path.GetFileName(path);
                string ruta = Path.Combine(crear_carpeta.rutaelegida, filename);
                StreamWriter codigonuevo = File.CreateText(ruta);

                codigonuevo.Write(modificar(path));
                codigonuevo.Flush();
                codigonuevo.Close();

            }
        }
        public string modificar(string path)//Modificamos el archivo css
        {
            string resultado = "";
            string filename = Path.GetFileName(Datos.ruta_imgFondo);
            new Leerarchivo().leerarchivo(path);
            resultado = Leerarchivo.texto;
            resultado = Regex.Replace(resultado, @"imagenfondo", filename);
            return resultado;
        }
    }
}
