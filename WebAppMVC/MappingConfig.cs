using AutoMapper;
using WebAppMVC.Models;
using WebAppMVC.Models.KoalaDtoFolder;

namespace WebAppAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<KoalaCustomer, KoalaCustomerDto>().ReverseMap();
        }
    }
}
