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
using Tarea3_LAP1_2Registro.UI.Registro;
using Tarea3_LAP1_2Registro.UI.Consulta;



namespace Tarea3_LAP1_2Registro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void RegistroEstudianteMenuItem_Click(object sender, RoutedEventArgs e)
        {
           rEstudiante RE = new rEstudiante();
           RE.Show();
        }
        private void RegistroCarreraMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rCarrera RC = new rCarrera();
            RC.Show();
        }
        //Consultas
        public void ConsultaEstudianteMenuItem_Click(object sender, RoutedEventArgs e)
        {
           cEstudiante CE = new cEstudiante();
           CE.Show();
        }

        public void ConsultaCarreraMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cCarrera CC =new cCarrera();
            CC.Show();
        }
    }
}
