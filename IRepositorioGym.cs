using TreeAppGym.App.Dominio;
using System.Collections.Generic;

namespace TreeAppGym.App.Persistencia
{
    public interface IRepositorioGym
    {
        Gym CrearGym(Gym gym);
        //Aunque se llama Gym por nomenclatura de la clase en realidad es el registro de los clientes con peso, fecha, estado y su respectiva Rutina cpn Plan Nutricional
        Gym ConsultarGym(int idGym);
        IEnumerable<Gym> ConsultarGyms();
        Gym ActualizarGym(Gym gym);
        void EliminarGym(int idGym);
    }
}