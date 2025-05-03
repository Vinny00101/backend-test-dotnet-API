using System;
using Microsoft.EntityFrameworkCore;

namespace backend_test_dotnet_API.Model;

public class AppDBContext : DbContext
{
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
    {
    }

    // tables...
}
