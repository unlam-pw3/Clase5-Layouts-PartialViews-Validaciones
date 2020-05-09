using Clase5LayoutsValidaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clase5LayoutsValidaciones.Servicios
{
    public class ComentarioServicio
    {
        public static List<Comentario> ObtenerListaRandom()
        {
            Usuario usuarioActual = new Usuario();
            usuarioActual.Id = 1;
            usuarioActual.NombreDeUsuario = "Peter29";
            usuarioActual.Puntos = 18255;
            usuarioActual.Avatar = "https://img2.freepng.es/20180623/iqh/kisspng-computer-icons-avatar-social-media-blog-font-aweso-avatar-icon-5b2e99c40ce333.6524068515297806760528.jpg";

            Usuario usuario2 = new Usuario()
            {
                Id = 2,
                NombreDeUsuario = "Dani22",
                Puntos = 200,
                Avatar = "https://image.flaticon.com/icons/svg/194/194938.svg"
            };

            List<Comentario> comentarios = new List<Comentario>();

            Random rand = new Random(DateTime.Now.Millisecond);
            int cantComentarios = rand.Next(1, 5);

            for (int i = 0; i < cantComentarios; i++)
            {
                var com = new Comentario();
                com.Mensaje = $"{DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss")} asdasdas ds ad as dsa ds";
                com.Usuario = usuario2;
                comentarios.Add(com);
            }

            return comentarios;
        }
    }
}