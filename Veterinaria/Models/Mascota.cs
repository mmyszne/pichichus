using System.ComponentModel.DataAnnotations;

namespace VeterinariaPichichus.Models
{
    public class Mascota
    {
        [Key]
        public int idMascota { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public TipoMascota Tipo { get; set; }
        public int Edad { get; set; }
        
        public string Raza { get; set; }
        
        public string Color { get; set; }
        public int Peso { get; set; }

        public Duenio? Duenio { get; set; }


    }
}
