using System.ComponentModel.DataAnnotations;

namespace VeterinariaPichichus.Models
{
    public class Duenio
    {
        [Key]
        public string? DNI { get; set; }
        [MaxLength(100)]
        public string? Nombre { get; set; }
        [MaxLength(100)]
        public string? Apellido { get; set; }
        [MaxLength(100)]
        public string? Email { get; set; }
        [MaxLength(15)]
        public int? Telefono { get; set; }
        [Required]
        public int MascotaId { get; set; }
        [Required]
        public Mascota MascotaDuenio { get; set; }





    }


}
