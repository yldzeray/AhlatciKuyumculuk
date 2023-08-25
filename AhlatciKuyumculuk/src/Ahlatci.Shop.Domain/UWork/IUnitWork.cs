using AhlatciKuyumculuk.Shop.Application.Repositories;
using AhlatciKuyumculuk.Shop.Domain.Common;

namespace AhlatciKuyumculuk.Shop.Domain.UWork
{
    public interface IUnitWork : IDisposable
    {
        public IRepository<T> GetRepository<T>() where T : BaseEntity;
        public Task<bool> CommitAsync();
    }
}
