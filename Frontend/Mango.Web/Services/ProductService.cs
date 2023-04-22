using Mango.Web.Models;
using Mango.Web.Services.IServices;

namespace Mango.Web.Services;

public class ProductService : BaseService, IProductService
{

    private readonly IHttpClientFactory _clientFacory;

    public ProductService(IHttpClientFactory clientFacory) : base(clientFacory)
    {
        _clientFacory = clientFacory;
    }

    public async Task<T> CreateProductAsync<T>(ProductDto productDto)
    {
        var request = new ApiRequest()
        {
            ApiType = SD.ApiType.POST,
            Data = productDto,
            Url = SD.ProductAPIBase + "api/products",
            AccessToken = ""
        };

        return await this.SendAsync<T>(request);
    }

    public async Task<T> DeleteProductAsync<T>(int id)
    {
        var request = new ApiRequest()
        {
            ApiType = SD.ApiType.DELETE,
            Url = SD.ProductAPIBase + "api/products/" + id,
            AccessToken = ""
        };

        return await this.SendAsync<T>(request);
    }

    public async Task<T> GetAllProductsAsync<T>()
    {
        var request = new ApiRequest()
        {
            ApiType = SD.ApiType.GET,
            Url = SD.ProductAPIBase + "api/products",
            AccessToken = ""
        };

        return await this.SendAsync<T>(request);
    }

    public async Task<T> GetProductByIdAsync<T>(int id)
    {
        var request = new ApiRequest()
        {
            ApiType = SD.ApiType.GET,
            Url = SD.ProductAPIBase + "api/products/" + id,
            AccessToken = ""
        };

        return await this.SendAsync<T>(request);
    }

    public async Task<T> UpdateProductAsync<T>(ProductDto productDto)
    {
        var request = new ApiRequest()
        {
            ApiType = SD.ApiType.PUT,
            Data = productDto,
            Url = SD.ProductAPIBase + "api/products",
            AccessToken = ""
        };

        return await this.SendAsync<T>(request);
    }
}