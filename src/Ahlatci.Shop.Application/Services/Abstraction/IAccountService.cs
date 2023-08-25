using AhlatciKuyumculuk.Shop.Application.Models.Dtos.Accounts;
using AhlatciKuyumculuk.Shop.Application.Models.RequestModels.Accounts;
using AhlatciKuyumculuk.Shop.Application.Wrapper;

namespace AhlatciKuyumculuk.Shop.Application.Services.Abstraction
{
    public interface IAccountService
    {
        Task<Result<bool>> Register(RegisterVM createUserVM);

        Task<Result<TokenDto>> Login(LoginVM loginVM);

        Task<Result<bool>> UpdateUser(UpdateUserVM updateUserVM);
    }
}
