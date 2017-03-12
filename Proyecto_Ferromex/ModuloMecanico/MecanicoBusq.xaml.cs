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
using System.Windows.Shapes;

namespace Proyecto_Ferromex.ModuloMecanico
{
    /// <summary>
    /// Lógica de interacción para MecanicoBusq.xaml
    /// </summary>
    public partial class MecanicoBusq : Window
    {
        public MecanicoBusq()
        {
            InitializeComponent();
        }

        private void BTN_Buscar_Click(object sender, RoutedEventArgs e)
        {
            Mecanico pMecanico = new Mecanico();
            pMecanico.nombre = TXT_Nombre.Text.Trim();
            pMecanico.app = TXT_App.Text.Trim();
            pMecanico.apm = TXT_Apm.Text.Trim();
            List<Mecanico> resultado = Mecanico_Reg.Buscar(pMecanico);
            DTG_MecBusq.ItemsSource = resultado;

        }





    }
}
