using VeterinariaPichichus.Context;


namespace VeterinariaPichichus.Models
{
    public class Actividad_Duenio
    {
        Persistir_Duenio Persistir_Duenio = new Persistir_Duenio();

        public bool GrabarDuenio(Duenio duenio)
        {
            return Persistir_Duenio.GrabarDuenio(duenio);
        }


        public Duenio? BuscarDuenioPorDNI(string dni)
        {
            return Persistir_Duenio.BuscarDuenioPorDNI(dni);

        }
        public List<Duenio> ObtengoTodosLosDuenios()
        {
            return Persistir_Duenio.ObtengoTodosLosDuenios();
        }
    }
}
