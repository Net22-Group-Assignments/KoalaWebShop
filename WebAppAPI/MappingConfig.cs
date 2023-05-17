using AutoMapper;
using WebAppAPI.Models.KoalaCustomerDto;
using WebAppMVC.Models;

namespace WebAppAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        {
            CreateMap<KoalaCustomer, KoalaCustomerApiDto>().ReverseMap();
        }
    }
}
