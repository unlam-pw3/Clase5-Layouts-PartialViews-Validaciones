using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Clase5LayoutsValidaciones.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Requerido")]
        public string NombreDeUsuario { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [RegularExpression(@"^(http|https)://(.+)", ErrorMessage ="Url incorrecta debe comenzar con http:// o https://")]
        public string Avatar { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [EmailAddress(ErrorMessage = "Formato de email invalido")]
        [CustomValidation(typeof(Usuario), "ValidarEmailUnico")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [StringLength(50, MinimumLength = 8, ErrorMessage ="Ingrese al menos 8 caracteres")]
        [Compare("ReContraseña", ErrorMessage = "Las contraseñas deben coincidir")]
        public string Contraseña { get; set; }

        [Required(ErrorMessage = "Requerido")]
        public string ReContraseña { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [Range(18, Int32.MaxValue, ErrorMessage = "Debe ser mayor a 18 años.")]
        public int Edad { get; set; }

        public int Puntos { get; set; }

        public static ValidationResult ValidarEmailUnico(object value, ValidationContext context)
        {
            var usuarioFormulario = context.ObjectInstance as Usuario;
            
            if(usuarioFormulario.Email != "pepe@gmail.com")
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Ya existe un usuario con ese email");
            }
        }
    }
}