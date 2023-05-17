using AutoMapper;
using WebAppMVC.Models;
using WebAppMVC.Models.Dto;

namespace WebAppAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<KoalaCustomer, KoalaCustomerDto>().ReverseMap();
            CreateMap<ProductReview, ProductReviewDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}
