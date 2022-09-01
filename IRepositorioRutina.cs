using TreeAppGym.App.Dominio;
using System.Collections.Generic;


namespace TreeAppGym.App.persistencia
{
    public interface IRepositorioRutina
    {
        Rutina CrearRutina(Rutina Rutina);
        Rutina ConsultarRutina(int idRutina);
        IEnumerable<Rutina> ConsultarRutina();
        Rutina ActualizarRutina(Rutina Rutina);
        void EliminarRutina(int idRutina);
    }
}