using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace TRMDataManager.Library.Internal.DataAccess
{
    internal class SqlDataAccess
    {
        public string GetConnectionString(string name) => ConfigurationManager.ConnectionStrings[name].ConnectionString;

        public List<TModel> LoadData<TModel, TParameters>(string storedProcedure, TParameters parameters, string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);
            using (var connection = new SqlConnection(connectionString))
            {
                var rows = connection.Query<TModel>(storedProcedure, parameters, commandType: CommandType.StoredProcedure).ToList();

                return rows;
            }
        }

        public void SaveData<TParameters>(string storedProcedure, TParameters parameters, string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
