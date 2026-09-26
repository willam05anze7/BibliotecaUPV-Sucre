using System.ComponentModel.DataAnnotations;

namespace Web_Modelo_VistaControlar.Models
{
    public class Prestamo
    {
        public int Id { get; set; }
        public int LibroId { get; set; }
        public Libro Libro { get; set; }
        public string UsuarioId { get; set; }
        public ApplicationUser Usuario { get; set; }

        [Display(Name = "Fecha de préstamo")]
        public DateTime FechaPrestamo { get; set; } = DateTime.Now;

        [Display(Name = "Fecha de devolución")]
        public DateTime? FechaDevolucion { get; set; }

        [Display(Name = "Estado")]
        public string Estado { get; set; } = "Pendiente";
    }
}
