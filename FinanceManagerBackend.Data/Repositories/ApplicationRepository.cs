using FinanceManagerBackend.Core.Model._Base;
using FinanceManagerBackend.Core.Repositories;
using Microsoft.Extensions.Logging;

namespace FinanceManagerBackend.Data.Repositories;

/// <summary>
/// Базовый репозиторий приложения
/// </summary>
/// <typeparam name="TEntity">модель</typeparam>
public class ApplicationRepository<TEntity> : EfCoreRepository<TEntity, ApplicationContext>
    where TEntity : class, IEntity
{
    private readonly ILogger<IEfCoreRepository<TEntity>> _logger;

    public ApplicationRepository(ApplicationContext context,
        ILogger<IEfCoreRepository<TEntity>> logger) : base(context, logger)
    {
    }
}