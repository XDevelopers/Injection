using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Injection.Data.Persistence
{
    public interface IMainDbContext : IDisposable
    {
    EntityEntry Entry(object entity);
    DbSet<TEntity> Set<TEntity>() where TEntity : class;
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}