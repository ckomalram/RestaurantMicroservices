using AutoMapper;
using Mango.Services.Product.API.Core.Context;
using Mango.Services.Product.API.Core.Models;
using Mango.Services.Product.API.Core.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.Product.API.Core.Repository;

public class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _appDbcontext;
    private IMapper _mapper;
    public ProductRepository(ApplicationDbContext appDbcontext, IMapper mapper)
    {
        _appDbcontext = appDbcontext;
        _mapper = mapper;
    }

    public async Task<ProductDto> CreateUpdateProduct(ProductDto productDto)
    {
        ProductModel product = _mapper.Map<ProductDto, ProductModel>(productDto);

        if (product.ProductId > 0)
        {
            // Exists
            _appDbcontext.Products.Update(product);
        }
        else
        {
            _appDbcontext.Products.Add(product);

        }

        await _appDbcontext.SaveChangesAsync();

        return _mapper.Map<ProductModel, ProductDto>(product);

    }

    public async Task<bool> DeleteProduct(int productId)
    {
        try
        {
            ProductModel product = await _appDbcontext.Products.FirstOrDefaultAsync(p => p.ProductId == productId);
            if (product == null)
            {
                return false;

            }
            _appDbcontext.Products.Remove(product);
            await _appDbcontext.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return false;
        }
    }

    public async Task<ProductDto> GetProductById(int productId)
    {
        ProductModel product = await _appDbcontext.Products.Where(x => x.ProductId == productId).FirstOrDefaultAsync();

        return _mapper.Map<ProductDto>(product);
    }

    public async Task<IEnumerable<ProductDto>> GetProducts()
    {
        List<ProductModel> productList = await _appDbcontext.Products.ToListAsync();

        return _mapper.Map<List<ProductDto>>(productList);
    }
}