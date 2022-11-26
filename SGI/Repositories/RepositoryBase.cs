using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SGI.Repositories
{
    public abstract class RepositoryBase
    {
        public readonly string _connectionString;
        public RepositoryBase()
        {
            _connectionString = "Data Source=CPM00004218\\SQLEXPRESS;Initial Catalog=DB_SGI_PGS;Integrated Security=True";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
