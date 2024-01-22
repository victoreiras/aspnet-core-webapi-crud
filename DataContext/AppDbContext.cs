using ASPNET_CORE_WEBAPI_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNET_CORE_WEBAPI_CRUD.DataContext;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<FuncionarioModel> Funcionarios { get; set; }
}