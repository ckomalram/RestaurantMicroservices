using AutoMapper;

namespace Mango.Services.Product.API.Core.Models.Dtos;


public class MappingProfile : Profile
{
    public MappingProfile()
    {
        //Product
        CreateMap<ProductModel, ProductDto>();

    }
}