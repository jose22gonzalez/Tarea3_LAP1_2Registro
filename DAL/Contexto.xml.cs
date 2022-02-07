using Microsoft.EntityFrameworkCore;
using Tarea3_LAP1_2Registro.Entidades;
using Tarea3_LAP1_2Registro.BLL;
namespace Tarea3_LAP1_2Registro.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Carrera> Carrera { get; set; }
        public DbSet<Estudiante> Estudiante { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= DATA\BaseData.db");
        }
    }

}
