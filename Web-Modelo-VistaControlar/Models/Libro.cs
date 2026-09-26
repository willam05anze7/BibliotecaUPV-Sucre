using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
namespace Web_Modelo_VistaControlar.Models
{
    public class Libro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Titulo es obligatorio")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "El campo Autor es obligatorio")]
        public string Autor { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "El campo Precio debe ser un número positivo")]
        public int Stock { get; set; }
    }
}
