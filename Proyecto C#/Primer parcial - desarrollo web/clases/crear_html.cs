using Primer_parcial___desarrollo_web.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace Primer_parcial___desarrollo_web.clases
{
    class crear_html
    {
        public static string path1 = "..\\..\\Resources\\index.html";
        public static string path3 = "..\\..\\Resources\\Habilidades.html";
        public static string path4 = "..\\..\\Resources\\hobbies.html";

        #region index
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
        public string modificar(string path)//Modificamos el archivo index
        {
            string resultado="";
            new Leerarchivo().leerarchivo(path);
            string filename = Path.GetFileName(Datos.ruta_img);
            resultado = Leerarchivo.texto;
            resultado = Regex.Replace(resultado, @"MiNombre", Datos.UIGlobal.MainPage.txtNombre.Text);
            resultado = Regex.Replace(resultado, @"MiCarnet", Datos.UIGlobal.MainPage.txtCarne.Text);
            resultado = Regex.Replace(resultado, @"MiFecha", Datos.UIGlobal.MainPage.txtFecha.Text);
            resultado = Regex.Replace(resultado, @"MiCiudad", Datos.UIGlobal.MainPage.txtCiudad.Text);
            resultado = Regex.Replace(resultado, @"imagenyo", filename);
            return resultado;
        }
        public void guardarimg(string ruta)
        {
            string filename = Path.GetFileName(ruta);
            string destFile = System.IO.Path.Combine(crear_carpeta.rutaelegida, filename);
            File.Copy(ruta, destFile);
        }
        #endregion

        #region habilidades
        public void generar_habi(string path)
        {
            if (File.Exists(path))
            {
                string filename = Path.GetFileName(path);
                string ruta = Path.Combine(crear_carpeta.rutaelegida, filename);
                StreamWriter codigonuevo = File.CreateText(ruta);

                codigonuevo.Write(modificar2(path));
                codigonuevo.Flush();
                codigonuevo.Close();

            }
        }
        public string modificar2(string path)//Modificamos el archivo index
        {
            string resultado = "";
            new Leerarchivo().leerarchivo(path);
            resultado = Leerarchivo.texto;
            for(int i =0;i<Datos.habilidades.Count; i++)
            {
                if (i == Datos.habilidades.Count - 1)
                {
                    resultado = Regex.Replace(resultado, @"<li>hola</li>", "<li>" + Datos.habilidades[i].Habilidad + "</li>");
                   
                }
                else
                {
                    resultado = Regex.Replace(resultado, @"<li>hola</li>", "<li>" + Datos.habilidades[i].Habilidad + "</li>\n<li>hola</li>");
                }
                
            }
            return resultado;
        }
        #endregion

        #region Hobbies
        public void generar_hobs(string path)
        {
            if (File.Exists(path))
            {
                string filename = Path.GetFileName(path);
                string ruta = Path.Combine(crear_carpeta.rutaelegida, filename);
                StreamWriter codigonuevo = File.CreateText(ruta);

                codigonuevo.Write(modificar3(path));
                codigonuevo.Flush();
                codigonuevo.Close();

            }
        }
        public string modificar3(string path)//Modificamos el archivo index
        {
            string resultado = "";
            new Leerarchivo().leerarchivo(path);
            resultado = Leerarchivo.texto;
            for (int i = 0; i < Datos.hobs.Count; i++)
            {
                if (i == Datos.hobs.Count - 1)
                {
                    resultado = Regex.Replace(resultado, @"<tr>\s*<td>1</td>\s*<td>hola</td>\s*</tr>", "<tr>\n<td>"+(i+1)+"</td>\n<td>" + Datos.hobs[i].Hobbies + "</td>\n</tr>");

                }
                else
                {
                    resultado = Regex.Replace(resultado, @"<tr>\s*<td>1</td>\s*<td>hola</td>\s*</tr>", "<tr>\n<td>" + (i + 1) + "</td>\n<td>" + Datos.hobs[i].Hobbies + "</td>\n</tr>" + "\n<tr>\n<td>1</td>\n<td>hola</td>\n</tr>");
                }

            }
            return resultado;
        }
        #endregion
    }
}
