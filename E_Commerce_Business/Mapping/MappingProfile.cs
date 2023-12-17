using AutoMapper;
using E_Commerce_DataAccess;
using E_Commerce_DataAccess.Models;
using E_Commerce_Models;

namespace E_Commerce_Business.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<ProductPrice, ProductPriceDTO>().ReverseMap();
            CreateMap<OrderHeaderDTO, OrderHeader>().ReverseMap();
            CreateMap<OrderDetailDTO, OrderDetail>().ReverseMap();
            CreateMap<OrderDTO, Order>().ReverseMap();

        }
    }
}
