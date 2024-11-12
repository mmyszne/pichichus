namespace VeterinariaPichichus.Models
{
    public class Servicio
    {
        public string Nombre { get; set; }
        public string DescripcionServicio { get; set; }
        public double Precio { get; set; }


        public Servicio(string nombre, string descripcionServicio, double precio)
        {
            Nombre = nombre;
            DescripcionServicio = descripcionServicio;
            Precio = precio;

        }
    }
}