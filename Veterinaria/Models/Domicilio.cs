namespace VeterinariaPichichus.Models
{
    public class Domicilio
    {
        public string Localidad { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }

        public Domicilio(string localidad, string calle, int altura)
        {
            Localidad = localidad;
            Calle = calle;
            Altura = altura;
        }
    }
}


