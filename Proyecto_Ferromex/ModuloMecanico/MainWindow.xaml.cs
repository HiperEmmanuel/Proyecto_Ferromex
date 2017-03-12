using Proyecto_Ferromex.ModuloMecanico;
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

namespace Proyecto_Ferromex
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Deshabilitar();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Habilitar();
        }

        
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

                Mecanico pMecanico = new Mecanico();
                pMecanico.nombre = TXT_Nombre.Text.Trim();
                pMecanico.app = TXT_App.Text.Trim();
                pMecanico.apm = TXT_Apm.Text.Trim();
                pMecanico.ciudad = TXT_Ciudad.Text.Trim();
                pMecanico.calle = TXT_Calle.Text.Trim();
                pMecanico.numero = Int32.Parse(TXT_Numero.Text.Trim());
                pMecanico.colonia = TXT_Colonia.Text.Trim();
                pMecanico.cp = Int32.Parse(TXT_CodPost.Text.Trim());
                pMecanico.curp = TXT_Curp.Text.Trim();
                pMecanico.rfc = TXT_Rfc.Text.Trim();
                pMecanico.fecha = TXT_FNacim.Text.Trim();
                pMecanico.telefono = TXT_Telef.Text.Trim();

                int resultado = Mecanico_Reg.InvocarSP(pMecanico);
                if (resultado > 0)
                {
                    MessageBox.Show("Mecanico Registrado Con Exito!!", "Guardado");
                }
                else
                {
                    MessageBox.Show("No se pudo Realizar el Registro", "Fallo!!");
                }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MecanicoBusq buscar = new MecanicoBusq();
            buscar.ShowDialog();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {

        }



        public void Deshabilitar()
        {
            TXT_Nombre.IsEnabled = false;
            TXT_App.IsEnabled = false;
            TXT_Apm.IsEnabled = false;
            TXT_Ciudad.IsEnabled = false;
            TXT_Calle.IsEnabled = false;
            TXT_Numero.IsEnabled = false;
            TXT_Colonia.IsEnabled = false;
            TXT_CodPost.IsEnabled = false;
            TXT_FNacim.IsEnabled = false;
            TXT_Rfc.IsEnabled = false;
            TXT_Telef.IsEnabled = false;
            TXT_Curp.IsEnabled = false;

            BTN_delete.IsEnabled = false;
            BTN_refresh.IsEnabled = false;
            BTN_save.IsEnabled = false;
        }
        public void Habilitar() {
            TXT_Nombre.IsEnabled = true;
            TXT_App.IsEnabled = true;
            TXT_Apm.IsEnabled = true;
            TXT_Ciudad.IsEnabled = true;
            TXT_Calle.IsEnabled = true;
            TXT_Numero.IsEnabled = true;
            TXT_Colonia.IsEnabled = true;
            TXT_CodPost.IsEnabled = true;
            TXT_FNacim.IsEnabled = true;
            TXT_Rfc.IsEnabled = true;
            TXT_Telef.IsEnabled = true;
            TXT_Curp.IsEnabled = true;

            BTN_delete.IsEnabled = true;
            BTN_refresh.IsEnabled = true;
            BTN_save.IsEnabled = true;
        }

        public void Limpiar() {
            TXT_Nombre.Clear();
            TXT_App.Clear();
            TXT_Apm.Clear();
            TXT_Ciudad.Clear();
            TXT_Calle.Clear();
            TXT_Numero.Clear();
            TXT_Colonia.Clear();
            TXT_CodPost.Clear();
            TXT_FNacim.Clear();
            TXT_Rfc.Clear();
            TXT_Telef.Clear();
            TXT_Curp.Clear();
        }

        private void BTN_delete_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
