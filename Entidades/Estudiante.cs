using System.Windows.Input;
using System.ComponentModel.DataAnnotations;
namespace Tarea3_LAP1_2Registro.Entidades
{
    public class Estudiante{

        
        public int EstudianteId { get; set; }

        public string Nombre { get; set; }
        public string? Email { get; set; }
      [Key]  public int CarreraId { get; set; }
         
        public Estudiante(int estudianteId, string nombre ,string  email, int carreraId){
          this.EstudianteId=estudianteId;
          this.CarreraId=carreraId;
          this.Nombre=nombre;
          this.Email=email;

        }

    }
}
