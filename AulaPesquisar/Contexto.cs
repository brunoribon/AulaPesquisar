using AulaPesquisar.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AulaPesquisar
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt) : base(opt) { }
        public DbSet<Pessoa> PESSOAS { get; set; }
        public DbSet<usuarios> usuarios { get; set; }
        public DbSet<permissao> permissao { get; set; }
        public DbSet<permissao_usuario> permissao_usuario { get; set; }
    }
}
