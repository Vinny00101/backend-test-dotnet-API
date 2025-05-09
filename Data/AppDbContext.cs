using System;
using backend_test_dotnet_API.Model;
using Microsoft.EntityFrameworkCore;

namespace backend_test_dotnet_API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<EstablishmentTable> Estabelecimento {get; set;}
    public DbSet<VehiclesTable> Veiculos {get; set;}
}
