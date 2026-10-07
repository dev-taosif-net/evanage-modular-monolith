using System.Data.Common;
using Evanage.Modules.Events.Application.Abstractions.Data;
using Npgsql;

namespace Evanage.Modules.Events.Infrastructure.Data;

internal sealed class DbConnectionFactory(NpgsqlDataSource dataSource) : IDbConnectionFactory
{
    public async ValueTask<DbConnection> OpenConnectionAsync()
    {
        return await dataSource.OpenConnectionAsync();
    }
}
