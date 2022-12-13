using SGI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.Repositories
{
    public class ContactsRepository : RepositoryBase, IContactsRepository
    {
        public ObservableCollection<ContactsModel> GetByStore()
        {
            ObservableCollection<ContactsModel> tiendas = new ObservableCollection<ContactsModel>();
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from CatTipoTienda";
                using (SqlDataReader reader = command.ExecuteReader()) 
                {
                    while (reader.Read())
                    {
                        tiendas.Add(new ContactsModel()
                        {
                            Id = (int)reader["Id"],
                            Tienda = reader["Tienda"].ToString()
                        });
                    }
                }
            }
            return tiendas;
        }
        public ObservableCollection<ContactsModel> GetByArea()
        {
            ObservableCollection<ContactsModel> areas = new ObservableCollection<ContactsModel>();
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from CatAreas order by NombreSuc asc";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        areas.Add(new ContactsModel()
                        {
                            Id = (int)reader["Id"],
                            NombreSuc = reader["NombreSuc"].ToString(),
                            TelTienda = reader["TelTienda"].ToString()
                        });
                    }
                }
            }
            return areas;
        }

    }
      
}
