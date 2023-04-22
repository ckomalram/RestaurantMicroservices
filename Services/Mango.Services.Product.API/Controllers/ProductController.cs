using Mango.Services.Product.API.Core.Models.Dtos;
using Mango.Services.Product.API.Core.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.Product.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    protected ResponseDto _reponse;
    private readonly IProductRepository _productRepository;

    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
        this._reponse = new ResponseDto();
    }

    [HttpGet]
    public async Task<ResponseDto> GetAll()
    {
        try
        {
            IEnumerable<ProductDto> productDtos = await _productRepository.GetProducts();
            _reponse.Result = productDtos;
        }
        catch (Exception ex)
        {
            _reponse.IsSuccess = false;
            _reponse.ErrorMessages = new List<string>() { ex.ToString() };
        }

        return _reponse;
    }

    [HttpGet("{productId}")]
    public async Task<ResponseDto> GetById(int productId)
    {
        try
        {
            ProductDto productDto = await _productRepository.GetProductById(productId);
            _reponse.Result = productDto;
        }
        catch (Exception ex)
        {
            _reponse.IsSuccess = false;
            _reponse.ErrorMessages = new List<string>() { ex.ToString() };
        }

        return _reponse;
    }

    [HttpPost]
    public async Task<ResponseDto> Post([FromBody] ProductDto productDto)
    {
        try
        {
            ProductDto model = await _productRepository.CreateUpdateProduct(productDto);
            _reponse.Result = model;
        }
        catch (Exception ex)
        {
            _reponse.IsSuccess = false;
            _reponse.ErrorMessages = new List<string>() { ex.ToString() };
        }

        return _reponse;
    }

    [HttpPut]
    public async Task<ResponseDto> Update([FromBody] ProductDto productDto)
    {
        try
        {
            ProductDto model = await _productRepository.CreateUpdateProduct(productDto);
            _reponse.Result = model;
        }
        catch (Exception ex)
        {
            _reponse.IsSuccess = false;
            _reponse.ErrorMessages = new List<string>() { ex.ToString() };
        }

        return _reponse;
    }


    [HttpDelete("{productId}")]
    public async Task<ResponseDto> Delete(int productId)
    {
        try
        {
            bool isDeleted = await _productRepository.DeleteProduct(productId);
            _reponse.Result = isDeleted;
        }
        catch (Exception ex)
        {
            _reponse.IsSuccess = false;
            _reponse.ErrorMessages = new List<string>() { ex.ToString() };
        }

        return _reponse;
    }

}
