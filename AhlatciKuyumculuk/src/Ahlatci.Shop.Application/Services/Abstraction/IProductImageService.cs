using AhlatciKuyumculuk.Shop.Application.Models.Dtos;
using AhlatciKuyumculuk.Shop.Application.Models.Dtos.ProductImages;
using AhlatciKuyumculuk.Shop.Application.Models.RequestModels.ProductImages;
using AhlatciKuyumculuk.Shop.Application.Wrapper;

namespace AhlatciKuyumculuk.Shop.Application.Services.Abstraction
{
    public interface IProductImageService
    {
        #region Select

        Task<Result<List<ProductImageDto>>> GetAllImagesByProduct(GetAllProductImageByProductVM getByProductVM);
        Task<Result<List<ProductImageWithProductDto>>> GetAllProductImagesWithProduct(GetAllProductImageByProductVM getByProductVM);

        #endregion

        #region Insert, Update, Delete

        Task<Result<int>> CreateProductImage(CreateProductImageVM createProductImageVM);
        Task<Result<int>> DeleteProductImage(DeleteProductImageVM deleteProductImageVM);

        #endregion
    }
}
