using StackExchange.Redis;

namespace FinanceManagerBackend.Data.Redis;

public interface IRedisDatabaseAccessor
{
    IDatabase GetDatabase(int dbNumber = -1);
    IServer GetServer();
}