﻿using AutoMapper;
using Shared.Authorization.Users;

namespace MainProduct.Product.Dto
{
    public class ProductMapProfile : Profile
    {
        public ProductMapProfile()
        {
            CreateMap<ProductInputOutputDto, Entities.Product>().ReverseMap();

            CreateMap<ProductInputOutputDto, Entities.Product>()
                .ForMember(x => x.CreationTime, opt => opt.Ignore());
        }
    }
}
