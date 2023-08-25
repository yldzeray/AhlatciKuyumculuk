using AhlatciKuyumculuk.Shop.Domain.Entities;

namespace AhlatciKuyumculuk.Shop.Domain.Services.Abstraction
{
    public interface ILoggedUserService
    {
        int? UserId { get; }
        Roles? Role { get; }
        string Username { get; }
        string Email { get; }
    }
}
