using AutoCerto.Model;
using Microsoft.EntityFrameworkCore;

namespace AutoCerto.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<UsuarioModel> Usuarios { get; set; }
}