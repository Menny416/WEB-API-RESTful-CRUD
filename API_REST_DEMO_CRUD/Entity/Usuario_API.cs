using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST_DEMO_CRUD.Entity
{
    public class Usuario_API
    {
        public string Nombre { get; set; }
        [Key]
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public bool EsActivo { get; set; }
        public DateTime FechaCreacion { get; set; }

    }
}
