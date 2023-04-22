using Mango.Services.Product.API.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.Product.API.Core.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<ProductModel> Products { get; set; }


}