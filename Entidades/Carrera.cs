using System.Windows.Input;
using System.ComponentModel.DataAnnotations;
namespace Tarea3_LAP1_2Registro.Entidades
{
    public class Carrera
    {


         [Key] public int CarreraId { get; set; }

        public string Nombre { get; set; }

        public Carrera(int carreraId, string nombre){

          this.CarreraId=carreraId;
          this.Nombre=nombre;

        }

    }
}
