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

        public ObservableCollection<ContactoModel> GetByAll()
        {
            ObservableCollection<ContactoModel> contactos = new ObservableCollection<ContactoModel>();
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select TbContactos.ID, Nombres, PrimerAP, SegundoAP, Celular, Email, Cargo, CatAreas.NombreSuc, CatTipoTienda.Tienda From TbContactos join CatAreas on TbContactos.idArea = CatAreas.ID left Outer join CatTipoTienda on TbContactos.idTienda = CatTipoTienda.ID";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        contactos.Add(new ContactoModel()
                        {
                            ID = (int)reader["ID"],
                            Nombres = reader["Nombres"].ToString(),
                            PrimerAP = reader["PrimerAP"].ToString(),
                            SegundoAP = reader["SegundoAP"].ToString(),
                            Celular = reader["Celular"].ToString(),
                            Email = reader["Email"].ToString(),
                            Cargo = reader["Cargo"].ToString(),
                            NombreSuc = reader["NombreSuc"].ToString(),
                            Tienda = reader["Tienda"].ToString()
                        });
                    }
                }
            }
            return contactos;
        }

        public void Add(string nombres, string primerAP, string segundoAP, string celular, string email, string cargo, string area, string tienda)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO TbContactos VALUES (@nombres, @primerAP, @segundoAP, @celular, @email, @cargo, @area, @tienda)";
                command.Parameters.AddWithValue("@nombres", nombres);
                command.Parameters.AddWithValue("@primerAP", primerAP);
                command.Parameters.AddWithValue("@segundoAP", segundoAP);
                command.Parameters.AddWithValue("@celular", celular);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@cargo", cargo);
                command.Parameters.AddWithValue("@area", area);
                command.Parameters.AddWithValue("@tienda", tienda);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
        }

        public void Delete(int Id)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Delete from TbContactos where ID = @id";
                command.Parameters.AddWithValue("@ID", Id);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
        }
    }
      
}
