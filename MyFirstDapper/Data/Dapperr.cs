using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstDapper.Data
{
    public class Dapperr : IDapper
    {
        public Dapperr(IConfiguration configuration)
        {
            _config = configuration;
        }
        private readonly IConfiguration _config;

        public async Task<T> Create<T>(string query, DynamicParameters pars, CommandType commandType = CommandType.StoredProcedure)
        {
            IDbConnection db = GetConnection();
            return await db.QueryFirstOrDefaultAsync<T>(query, pars, commandType: commandType);
        }

        public async Task<T> Delete<T>(string query, DynamicParameters pars, CommandType commandType = CommandType.StoredProcedure)
        {
            IDbConnection db = GetConnection();
            return await db.QueryFirstOrDefaultAsync<T>(query, pars, commandType: commandType);
        }

        public async Task<T> Get<T>(string query, DynamicParameters pars, CommandType commandType = CommandType.StoredProcedure)
        {
            IDbConnection db = GetConnection();
            return await db.QueryFirstOrDefaultAsync<T>(query, pars, commandType: commandType);
        }

        public async Task<IEnumerable<T>> GetAll<T>(string query, DynamicParameters pars, CommandType commandType = CommandType.StoredProcedure)
        {
            IDbConnection db = GetConnection();
            return await db.QueryAsync<T>(query, pars, commandType: commandType);
        }

        public DbConnection GetConnection()
        {
            return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
        }

        public async Task<T> Update<T>(string query, DynamicParameters pars, CommandType commandType = CommandType.StoredProcedure)
        {
            IDbConnection db = GetConnection();
            return await db.QueryFirstOrDefaultAsync<T>(query, pars, commandType: commandType);
        }

        public void Dispose()
        {
        }
    }
}
