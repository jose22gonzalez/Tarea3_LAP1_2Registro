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
using Tarea3_LAP1_2Registro.BLL;
using Tarea3_LAP1_2Registro.Entidades;

namespace Tarea3_LAP1_2Registro.UI.Consulta
{
    /// <summary>
    /// Interaction logic for cCarrera.xaml
    /// </summary>
    public partial class cCarrera : Window
    {
        public cCarrera()
        {
            InitializeComponent();
        }

        public void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Carrera>();

            if (string.IsNullOrWhiteSpace(CriterioTextBox.Text))         
                listado = CarreraBLL.GetList(l => true);
            else
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: 
                        listado = CarreraBLL.GetList(l => l.CarreraId.ToString().Contains(CriterioTextBox.Text));
                        break;
                    case 1:  
                        listado = CarreraBLL.GetList(l => l.Nombre.Contains(CriterioTextBox.Text));
                        break;
                    case 3:
                        listado = CarreraBLL.GetList(l=>l.CarreraId.ToString().Contains(CriterioTextBox.Text)); 
                    break;
                }
            }
            CarreraDataGrid.ItemsSource = null;
            CarreraDataGrid.ItemsSource = listado;
        }

        
    }
}
