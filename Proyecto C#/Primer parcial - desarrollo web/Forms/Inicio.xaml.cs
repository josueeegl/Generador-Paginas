using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Primer_parcial___desarrollo_web.Forms
{
    /// <summary>
    /// Lógica de interacción para Inicio.xaml
    /// </summary>
    public partial class Inicio : Page
    {
        public Inicio()
        {
            InitializeComponent();
            UIGlobal.MainPage = this;
        }

        private void BtnCarpeta_Click(object sender, RoutedEventArgs e)
        {
            new clases.crear_carpeta().crearcarpeta();
            new Forms.Datos().Show();
            
        }

        public static class UIGlobal
        {
            public static Inicio MainPage { get; set; }
        }
    }
}
