using System.ComponentModel.DataAnnotations;

namespace Mango.Services.Product.API.Core.Models;

public class ProductModel
{
    [Key]
    public int ProductId { get; set; }

    [Required]
    public string Name { get; set; }
    [Range(1, 5000)]
    public double Price { get; set; }

    public string Description { get; set; }
    public string CategoryName { get; set; }
    public string ImageUrl { get; set; }

}