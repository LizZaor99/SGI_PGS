﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.Models
{
    public class UserModel
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public string primer_apellido { get; set; }
        public string segundo_apellido { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string usuario { get; set; } 
        public string password { get; set; }
    }
}
