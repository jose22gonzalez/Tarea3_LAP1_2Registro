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
    /// Interaction logic for cCarrera.xaml
    /// </summary>
    public partial class rCarrera : Window
    {
        public rCarrera()
        {
            InitializeComponent();

            var lista = CarreraBLL.GetLista();
            DataCarreraGrid.ItemsSource = lista;
        }

        private void Clcik_GuardarButton(object sender, RoutedEventArgs e)
        {


            Carrera carreras = new Carrera(int.Parse(carreraidTextBox.Text), nombrecombobox.Text);

            if (!CarreraBLL.Existes(int.Parse(carreraidTextBox.Text)))
            {
                var paso = CarreraBLL.Insertar(carreras);
            }
            else
            {
                MessageBox.Show("El RolID que ingreso ya existe");
            }
            var lista = CarreraBLL.GetLista();
            DataCarreraGrid.ItemsSource = lista;
        }

        private void Clcik_EditarButton(object sender, RoutedEventArgs e)
        {

            Carrera carreras = new Carrera(int.Parse(carreraidTextBox.Text), nombrecombobox.Text);


            var paso = CarreraBLL.Existe(carreras, int.Parse(carreraidTextBox.Text));
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


            var lista = CarreraBLL.GetLista();
            DataCarreraGrid.ItemsSource = lista;
        }

        private void Clcik_EliminarButton(object sender, RoutedEventArgs e)
        {

            if (CarreraBLL.Eliminar(int.Parse(carreraidTextBox.Text)))
            {

                MessageBox.Show("Registro Eliminado", "Exito",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No fue posible Eliminar", "Fallo",
                MessageBoxButton.OK, MessageBoxImage.Error);
            }
            var lista = CarreraBLL.GetLista();
            DataCarreraGrid.ItemsSource = lista;


        }

    }
}
