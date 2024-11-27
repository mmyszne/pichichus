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
    //{
    //    public static void Agregar(Contexto conexion, Estudiante estudiante)
    //    {
    //        try
    //        {
    //            conexion.Estudiantes.Add(estudiante);
    //            conexion.SaveChanges();
    //        }
    //        catch (Exception e)
    //        {
    //            throw e;    // reenvía la exception para mostrarla en el Program
    //        }
    //    }

    //    public static string ListarEstudiantes(Contexto conexion)
    //    {
    //        string? resultado = "";

    //        if (conexion.Estudiantes.Count() > 0)   //Si no hay estudiantes, retorna cadena vacía
    //        {
    //            resultado = "Listado de Estudiantes\n";

    //            foreach (var item in conexion.Estudiantes)
    //            {
    //                resultado += $"{item.Nombre} {item.Apellido}\n";
    //            }
    //        }
    //        return resultado;
    //    }

    //    public static void Eliminar(Contexto conexion, Estudiante alu)
    //    {
    //        //Busca el estudiante por Legajo para eliminarlo
    //        try
    //        {
    //            var estudianteAEliminar = conexion.Estudiantes.Where(elem => elem.Legajo == alu.Legajo).FirstOrDefault();

    //            if (estudianteAEliminar != null)
    //            {
    //                conexion.Estudiantes.Remove(estudianteAEliminar);
    //                conexion.SaveChanges();
    //            }
    //            else
    //            {   // Genera una excepcion para notificar
    //                throw new Exception($"El estudiante con legajo {alu.Legajo} no existe en la base de datos!");
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            throw e;    // reenvía la exception para mostrarla en el Program
    //        }
    //    }

    //    public static void Modificar(Contexto conexion, Estudiante alu)
    //    {   //Busca el estudiante por Legajo, es el atributo que no se puede modificar porque identifica al estudiante
    //        try
    //        {
    //            var estudianteAModificar = conexion.Estudiantes.Where(elem => elem.Legajo == alu.Legajo).FirstOrDefault();

    //            if (estudianteAModificar != null)
    //            {
    //                estudianteAModificar.Nombre = alu.Nombre;       //se asigna nombre nuevo
    //                estudianteAModificar.Apellido = alu.Apellido;   //se asigna apellido nuevo

    //                conexion.Update(estudianteAModificar);
    //                conexion.SaveChanges();
    //            }
    //            else
    //            {   // Genera una excepcion para notificar
    //                throw new Exception($"El estudiante con legajo {alu.Legajo} no existe en la base de datos!");
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            throw e;    // reenvía la exception para mostrarla en el Program
    //        }
    //    }
    //}
}
