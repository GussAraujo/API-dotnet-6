using Microsoft.EntityFrameworkCore;

namespace MiniTodo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Data Source=DESKTOP-5IEKPRR;Initial Catalog=ApiMinimal;Integrated Security=True");
    }
}