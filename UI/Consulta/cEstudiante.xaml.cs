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
    /// Interaction logic for cEstudiante.xaml
    /// </summary>
    public partial class cEstudiante : Window
    {
        public cEstudiante()
        {
            InitializeComponent();
        }

        public void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Estudiante>();

            if (string.IsNullOrWhiteSpace(CriterioTextBox.Text))         
                listado = EstudianteBLL.GetList(l => true);
            else
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: 
                        listado = EstudianteBLL.GetList(l => l.EstudianteId.ToString().Contains(CriterioTextBox.Text));
                        break;
                    case 1:  
                        listado = EstudianteBLL.GetList(l => l.Nombre.Contains(CriterioTextBox.Text));
                        break;
                    case 3:
                        listado = EstudianteBLL.GetList(l=>l.CarreraId.ToString().Contains(CriterioTextBox.Text)); 
                    break;
                }
            }
            EstudianteDataGrid.ItemsSource = null;
            EstudianteDataGrid.ItemsSource = listado;
        }
    }
}
