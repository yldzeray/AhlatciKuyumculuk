using AhlatciKuyumculuk.Shop.Application.Models.RequestModels;
using AhlatciKuyumculuk.Shop.Application.Models.RequestModels.Accounts;
using AhlatciKuyumculuk.Shop.Application.Models.RequestModels.Cities;
using AhlatciKuyumculuk.Shop.Application.Models.RequestModels.OrderDetails;
using AhlatciKuyumculuk.Shop.Application.Models.RequestModels.Orders;
using AhlatciKuyumculuk.Shop.Application.Models.RequestModels.ProductImages;
using AhlatciKuyumculuk.Shop.Application.Models.RequestModels.Products;
using AhlatciKuyumculuk.Shop.Domain.Entities;
using AutoMapper;

namespace AhlatciKuyumculuk.Shop.Application.Automappings
{
    public class ViewModelToDomain : Profile
    {
        public ViewModelToDomain()
        {
            //Kaynak ve hedef arasında property isimleri veya türleri eşleşmezse manuel tanımlama yapmak gerekir.
            CreateMap<CreateCategoryVM, Category>()
                .ForMember(x => x.Name, y => y.MapFrom(e => e.CategoryName));

            CreateMap<UpdateCategoryVM, Category>()
                .ForMember(x => x.Name, y => y.MapFrom(e => e.CategoryName));

            //Kullanıcı oluşturma isteği
            CreateMap<RegisterVM, Customer>();
            CreateMap<RegisterVM, Account>()
                .ForMember(x => x.Role, y => y.MapFrom(e => Roles.User));

            CreateMap<UpdateUserVM, Customer>();

            //City
            CreateMap<CreateCityVM, City>()
                .ForMember(x => x.Name, y => y.MapFrom(e => e.Name.ToUpper()));
            CreateMap<UpdateCityVM, City>()
                .ForMember(x => x.Name, y => y.MapFrom(e => e.Name.ToUpper()));

            //Product
            CreateMap<CreateProductVM, Product>()
                .ForMember(x=>x.Name, y=>y.MapFrom(e=>e.Name.Trim()));
            CreateMap<UpdateProductVM, Product>()
                .ForMember(x => x.Name, y => y.MapFrom(e => e.Name.Trim()));

            //ProductImage
            CreateMap<CreateProductImageVM, ProductImage>();

            //Order
            CreateMap<CreateOrderVM, Order>();
            CreateMap<UpdateOrderVM, Order>();

            //OrderDetail
            CreateMap<CreateOrderDetailVM, OrderDetail>();

        }
    }
}
