﻿using AutoMapper;
using WebAppMVC.Models;
using WebAppMVC.Models.Dto;
using WebAppMVC.Models.ViewModels;

namespace WebAppMVC
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<KoalaCustomer, KoalaCustomerDto>().ReverseMap();
            CreateMap<Review, ReviewDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}
