using AhlatciKuyumculuk.Shop.Application.Models.Dtos;
using AhlatciKuyumculuk.Shop.Application.Models.Dtos.Accounts;
using AhlatciKuyumculuk.Shop.Application.Models.Dtos.Cities;
using AhlatciKuyumculuk.Shop.Application.Models.Dtos.Customers;
using AhlatciKuyumculuk.Shop.Application.Models.Dtos.OrderDetails;
using AhlatciKuyumculuk.Shop.Application.Models.Dtos.Orders;
using AhlatciKuyumculuk.Shop.Application.Models.Dtos.ProductImages;
using AhlatciKuyumculuk.Shop.Application.Models.Dtos.Products;
using AhlatciKuyumculuk.Shop.Domain.Entities;
using AutoMapper;

namespace AhlatciKuyumculuk.Shop.Application.Automappings
{
    public class DomainToDto : Profile
    {
        public DomainToDto()
        {
            CreateMap<Category, CategoryDto>();

            CreateMap<Customer, CustomerDto>();

            CreateMap<Account, AccountDto>();

            CreateMap<City, CityDto>();

            CreateMap<Product, ProductDto>();
            CreateMap<Product, ProductWithCategoryDto>();
            CreateMap<Product, ProductWithImagesDto>();

            CreateMap<ProductImage, ProductImageDto>();
            CreateMap<ProductImage, ProductImageWithProductDto>();

            CreateMap<Order, OrderDto>();

            CreateMap<OrderDetail, OrderDetailDto>();
        }
    }
}
