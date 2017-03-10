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
        }
        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            Mecanico pMecanico = new Mecanico();
            pMecanico.nombre = TXT_Nombre.Text.Trim();
            pMecanico.app = TXT_App.Text.Trim();
            pMecanico.apm = TXT_Apm.Text.Trim();
            pMecanico.ciudad = TXT_Ciudad.Text.Trim();
            pMecanico.calle = TXT_Calle.Text.Trim();
            pMecanico.numero= Int32.Parse(TXT_Numero.Text.Trim());
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
    }
}
