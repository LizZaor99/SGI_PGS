using SGI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.Repositories
{
    public class HomeRepository : RepositoryBase, IHomeRepository
    {
        public int GetByStatus(int tipoEquipo, int status)
        {
            int COUNT;
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select count(ID) from [TbEquipos] where idTipoEq=@tipoEquipo and idEstatus=@status";
                command.Parameters.Add("@tipoEquipo", SqlDbType.NVarChar).Value = tipoEquipo;
                command.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;
                COUNT = Convert.ToInt32(command.ExecuteScalar());
            }
            return COUNT;
        }
    }
}
