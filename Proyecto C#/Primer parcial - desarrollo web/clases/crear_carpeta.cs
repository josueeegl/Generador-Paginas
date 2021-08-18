using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Primer_parcial___desarrollo_web.clases
{
    
    class crear_carpeta
    {
        public static string rutaelegida = "";
       public void crearcarpeta()
        {
            var dialog = new Microsoft.Win32.SaveFileDialog();
            dialog.Title = "Seleccione ruta";
            dialog.FileName = "Mi pagina";
            if (dialog.ShowDialog() == true)
            {
                rutaelegida = dialog.FileName;
                rutaelegida = rutaelegida.Replace("Seleccione ruta", "");
                rutaelegida = rutaelegida.Replace(".carpeta", "");
                if (!System.IO.Directory.Exists(rutaelegida))
                {
                    System.IO.Directory.CreateDirectory(rutaelegida);
                }
            }
        }
        
    }
}
