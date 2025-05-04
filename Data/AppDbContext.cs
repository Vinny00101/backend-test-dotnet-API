using System;
using Microsoft.EntityFrameworkCore;

namespace backend_test_dotnet_API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
}
