using Mango.Services.Product.API.Core.Models.Dtos;

namespace Mango.Services.Product.API.Core.Repository;

public interface IProductRepository
{
    Task<IEnumerable<ProductDto>> GetProducts();
    Task<ProductDto> GetProductById(int productId);
    Task<ProductDto> CreateUpdateProduct(ProductDto productDto);
    Task<bool> DeleteProduct(int productId);

}