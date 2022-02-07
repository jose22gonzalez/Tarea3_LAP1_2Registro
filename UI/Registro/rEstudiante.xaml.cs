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



namespace Tarea3_LAP1_2Registro.UI.Registro
{
    /// <summary>
    /// Interaction logic for cEstudiante.xaml
    /// </summary>
    public partial class rEstudiante : Window
    {
        public rEstudiante()
        {
            InitializeComponent();
            
            var lista = EstudianteBLL.GetLista();
            DataEstudiateGrid.ItemsSource = lista;
            
        }

        private void GuardarClick_Button(object sender, RoutedEventArgs e)
        {


             Estudiante estudiante= new  Estudiante (int.Parse(EstudianteIDTextBox.Text),NombreTextBox.Text,EmailTextBox.Text,int.Parse(CarreraID.Text));
            
            if (!EstudianteBLL.Existes(int.Parse(EstudianteIDTextBox.Text)))
            {
                   var paso = EstudianteBLL.Insertar(estudiante);
            }
            else
            {
                MessageBox.Show("El RolID que ingreso ya existe");
            }
           
                
             var lista =EstudianteBLL.GetLista();
             DataEstudiateGrid.ItemsSource = lista;
        }

        private void EditarClick_Button(object sender, RoutedEventArgs e)
        {
          
          Estudiante estudiante= new  Estudiante (int.Parse(EstudianteIDTextBox.Text),NombreTextBox.Text,EmailTextBox.Text,int.Parse(CarreraID.Text));


            var paso = EstudianteBLL.Existe(estudiante,int.Parse(EstudianteIDTextBox.Text));
            if (paso)
            {
               
                MessageBox.Show("Registro Editado ", "Exito",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                 MessageBox.Show("No se fue posible Editado ", "Fallo",
                MessageBoxButton.OK, MessageBoxImage.Error);

               
            }


            var lista =EstudianteBLL.GetLista();
            DataEstudiateGrid.ItemsSource = lista;
            
            
            

        }

        private void EliminarClick_Button(object sender, RoutedEventArgs e)
        {
            
            if (EstudianteBLL.Eliminar(int.Parse(EstudianteIDTextBox.Text)))
            {

                MessageBox.Show("Registro Eliminado", "Exito",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No fue posible Eliminar", "Fallo",
                MessageBoxButton.OK, MessageBoxImage.Error);
            }
            var lista = EstudianteBLL.GetLista();
            DataEstudiateGrid.ItemsSource = lista;
            
            

        }
    }
}
