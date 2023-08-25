using AhlatciKuyumculuk.Shop.Application.Models.Dtos.OrderDetails;
using AhlatciKuyumculuk.Shop.Application.Models.RequestModels.OrderDetails;
using AhlatciKuyumculuk.Shop.Application.Models.RequestModels.Orders;
using AhlatciKuyumculuk.Shop.Application.Wrapper;

namespace AhlatciKuyumculuk.Shop.Application.Services.Abstraction
{
    public interface IOrderDetailService
    {
        #region Select
        Task<Result<List<OrderDetailDto>>> GetOrderDetailsByOrderId(GetOrderDetailsByOrderIdVM getByOrderIdVM);

        #endregion

        #region Insert, Update, Delete

        Task<Result<int>> CreateOrderDetail(CreateOrderDetailVM createOrderDetailVM);
        Task<Result<int>> DeleteOrderDetail(DeleteOrderDetailVM deleteOrderDetailVM);

        #endregion
    }
}
