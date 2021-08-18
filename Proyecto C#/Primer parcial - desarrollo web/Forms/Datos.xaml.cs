using DocumentFormat.OpenXml.Office.CustomUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Primer_parcial___desarrollo_web.Forms
{
    /// <summary>
    /// Lógica de interacción para Datos.xaml
    /// </summary>
    public partial class Datos : Window
    {
        public static List<Item> habilidades = new List<Item>();
        public static List<Item> hobs = new List<Item>();
        public static string ruta_img = "";
        public static string ruta_imgFondo = "";

        public Datos()
        {
            InitializeComponent();
            UIGlobal.MainPage = this;
            generate_columns();
        }

        private void BtnImgFondo_Click(object sender, RoutedEventArgs e)
        {
            obtener_imagenFondo();
        }

        private void BtnGenerar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                obtener_datos();
                new clases.crear_html().guardar_en_carpeta(clases.crear_html.path1);
                new clases.generar_css().guardar_en_carpeta(clases.generar_css.path2);
                new clases.crear_html().generar_habi(clases.crear_html.path3);
                new clases.crear_html().generar_hobs(clases.crear_html.path4);
                new clases.crear_html().guardarimg(ruta_img);
                new clases.crear_html().guardarimg(ruta_imgFondo);
                MessageBox.Show("Tu pagina está lista" );
                this.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Error; " + ec.Message);
            }
        }
        public static class UIGlobal
        {
            public static Datos MainPage { get; set; }
        }
        private void BtnImagen_Click(object sender, RoutedEventArgs e)
        {
            obtener_imagen();
        }
        public void obtener_imagen()
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.InitialDirectory = "";
            dialog.Filter = "Imagenes|*.jpg;*.png;*.jpeg";
            dialog.FilterIndex = 3;
            dialog.Title = "Cargador de imagenes";
            if (dialog.ShowDialog() == true)
            {
                imgcargar.Source = ToImageSource(dialog.FileName);
            }
            ruta_img = dialog.FileName;
        }//obtenemos la imagen pefil
        public void obtener_imagenFondo()
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.InitialDirectory = "";
            dialog.Filter = "Imagenes|*.jpg;*.png;*.jpeg";
            dialog.FilterIndex = 3;
            dialog.Title = "Cargador de imagenes";
            if (dialog.ShowDialog() == true)
            {
                imgFondo.Source = ToImageSource(dialog.FileName);
            }
            ruta_imgFondo = dialog.FileName;
        }//obtenemos la imagen de fondo
        public BitmapImage ToImageSource(string path)
        {
            BitmapImage _bitmap = new BitmapImage();
            _bitmap.BeginInit();
            _bitmap.UriSource = new Uri(path);
            _bitmap.EndInit();
            return _bitmap;

        }//mostamos la imagen en pantalla
        private void generate_columns()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item() { Habilidad = "C#" });
            gridHabilidades.ItemsSource = null;
            gridHabilidades.ItemsSource = items;
            List<Item> items2 = new List<Item>();
            items2.Add(new Item() { Hobbies = "Ver peliculas" });
            gridHobbies.ItemsSource = null;
            gridHobbies.ItemsSource = items2;
        }
        public class Item
        {
            public string Habilidad { get; set; }
            public string Hobbies { get; set; }
        }
        public void obtener_datos() //se obtiene la lista de habilidades y hobbies
        {
            for(int i = 0; i < gridHabilidades.Items.Count-1; i++)
            {
                habilidades.Add((Item)gridHabilidades.Items[i]);
            }
            for (int i = 0; i < gridHobbies.Items.Count-1; i++)
            {
                hobs.Add((Item)gridHobbies.Items[i]);
            }
        }
    }
}
