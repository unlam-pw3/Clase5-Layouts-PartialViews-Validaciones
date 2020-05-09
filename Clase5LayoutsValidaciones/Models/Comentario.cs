using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clase5LayoutsValidaciones.Models
{
    public class Comentario
    {
        public int Id { get; set; }

        public string Mensaje { get; set; }
        public Usuario Usuario { get; set; }
    }
}