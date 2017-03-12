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
        public object MecActual { get; private set; }
        public int IDActual{get;set;}

        public MainWindow()
        {
            InitializeComponent();
            Deshabilitar();
            BTN_add.IsEnabled = true;
            BTN_search.IsEnabled = true;
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Habilitar();
            BTN_refresh.IsEnabled = false;
            BTN_delete.IsEnabled = false;
            BTN_search.IsEnabled = false;
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
            pMecanico.id = IDActual;

            if (Mecanico_Reg.Actualizar(pMecanico) > 0)
            {
                MessageBox.Show("Los datos del Mecanico se actualizaron", "Datos Actualizados");
                Limpiar();
                Deshabilitar();

            }
            else
            {
                MessageBox.Show("No se pudo actualizar", "Error al Actualizar");

            }




        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MecanicoBusq buscar = new MecanicoBusq();
            buscar.ShowDialog();
            if (buscar.MecSelect != null)
            {
                MecActual = buscar.MecSelect;
                TXT_Nombre.Text = buscar.MecSelect.nombre;
                TXT_App.Text = buscar.MecSelect.app;
                TXT_Apm.Text = buscar.MecSelect.apm;
                TXT_Calle.Text = buscar.MecSelect.calle;
                TXT_Ciudad.Text = buscar.MecSelect.ciudad;
                TXT_Numero.Text  = Convert.ToString(buscar.MecSelect.numero);
                TXT_Colonia.Text = buscar.MecSelect.colonia;
                TXT_CodPost.Text = Convert.ToString(buscar.MecSelect.cp);
                TXT_Curp.Text = buscar.MecSelect.curp;
                TXT_Rfc.Text = buscar.MecSelect.rfc;
                TXT_FNacim.Text = buscar.MecSelect.fecha;
                TXT_Telef.Text = buscar.MecSelect.telefono;
                IDActual = buscar.MecSelect.id;

                BTN_refresh.IsEnabled = true;
                BTN_delete.IsEnabled = true;
                Habilitar();
                BTN_save.IsEnabled = false;
            }
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
            BTN_cancel.IsEnabled = false;
            BTN_add.IsEnabled = false;
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
            BTN_cancel.IsEnabled = true;
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

                if (Mecanico_Reg.Eliminar(IDActual) > 0)
                {
                    MessageBox.Show("Cliente Eliminado Correctamente!", "Cliente Eliminado");
                    Limpiar();
                    Deshabilitar();
                }


        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Limpiar();
            Deshabilitar();
            BTN_add.IsEnabled = true;
            BTN_search.IsEnabled = true;
        }
    }
}
