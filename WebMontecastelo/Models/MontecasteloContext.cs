using Microsoft.EntityFrameworkCore;

namespace WebMontecastelo.Models
{
    public class MontecasteloContext : DbContext
    {
        public MontecasteloContext(DbContextOptions<MontecasteloContext> options) : base(options) { }
        public DbSet<Asignaturas> Asignaturas { get; set; }
        public DbSet<Estudiantes> Estudiantes { get; set; }
        public DbSet<Logins> Logins { get; set; }
        public DbSet<Matriculas> Matriculas { get; set;}
        public DbSet<Profesores> Profesores { get; set;}
    }
}
