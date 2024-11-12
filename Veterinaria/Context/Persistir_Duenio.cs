using VeterinariaPichichus.Models;

namespace VeterinariaPichichus.Context
{
    public class Persistir_Duenio
    {
        List<Duenio> duenios = new List<Duenio>();

        public bool GrabarDuenio(Duenio duenio)
        {
            bool estado = false;

            if (duenio != null)
            {
                duenios.Add(duenio);
                estado = true;
            }
            return estado;
        }

        public Duenio? BuscarDuenioPorDNI(string DNI)
        {
         Duenio? duenioBuscado = (from d in duenios where d.DNI == DNI select d).FirstOrDefault();
            return duenioBuscado;
        }
        public List<Duenio> ObtengoTodosLosDuenios()
        {
            return duenios;
        }
    }
}
