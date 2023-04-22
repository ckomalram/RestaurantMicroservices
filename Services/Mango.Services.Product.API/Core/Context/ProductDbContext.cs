using Microsoft.EntityFrameworkCore;

namespace Mango.Services.Product.API.Core.Context;

public class ProductDbContext : DbContext
{
    public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
    {

    }

}