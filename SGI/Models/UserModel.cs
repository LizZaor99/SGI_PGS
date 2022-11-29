using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.Models
{
    public class UserModel
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Usuario { get; set; } 
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
