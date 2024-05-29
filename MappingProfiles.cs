using System;
using AutoMapper;
using UnitOfWorkDemo.DTOS;
using UnitOfWorkDemo.Models;

namespace UnitOfWorkDemo
{
	public class MappingProfiles : Profile
	{
		public MappingProfiles()
        {
            CreateMap<AddProductDTO, ProductDetails>();
                //.ForMember(
                //    dest => dest.ProductName,
                //    opt => opt.MapFrom(src => src.ProductName)
                //)
                //.ForMember(
                //    dest => dest.ProductDescription,
                //    opt => opt.MapFrom(src => src.ProductDescription)
                //)
                //.ForMember(
                //    dest => dest.ProductPrice,
                //    opt => opt.MapFrom(src => src.ProductPrice)
                //)
                //.ForMember(
                //    dest => dest.ProductStock,
                //    opt => opt.MapFrom(src => src.ProductStock)
                //);
        }
    }
}

