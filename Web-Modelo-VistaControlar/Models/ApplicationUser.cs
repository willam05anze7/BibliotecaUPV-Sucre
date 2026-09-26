using Microsoft.AspNetCore.Identity;
namespace Web_Modelo_VistaControlar.Models
{
    public class ApplicationUser : IdentityUser
    {
       public string NombreCompleto { get; set; }

    }
}
