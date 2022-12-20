using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.Models
{
    public class ContactsModel
    {
        public int Id { get; set; }
        public string Tienda { get; set; }
        public string NombreSuc { get; set; }
        public string TelTienda { get; set; }
    }
    public class ContactoModel
    {
        public int ID { get; set; }
        public string Nombres { get; set; }
        public string PrimerAP { get; set; }
        public string SegundoAP { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public string idArea { get; set; }
        public string idTienda { get; set; }
        public string NombreSuc { get; set; }
        public string Tienda { get; set; }  
    }
}
