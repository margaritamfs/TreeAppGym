using TreeAppGym.App.Dominio;
// para que pueda leer donde está la entidad Rutina
using System.Collections.Generic;
// para que no me marque error con las listas numeradas, importa todo lo que tiene que ver con listas
// en este paquete se encuentra todo lo que tiene que ver con listas

namespace TreeAppGym.App.Persistencia{

    public interface IRepositorioRutina{

        Rutina CrearRutina(Rutina Rutina);

        Rutina ConsultarRutina(int idRutina);
        // aqui quiero que me retorne todas las listas de planes nutricionales
        IEnumerable<Rutina> ConsultarRutinas();
        
        Rutina ActualizarRutina(Rutina Rutina);

        void EliminarRutina(int idRutina);
        // vacío porque no necesito que al eliminar me retorne nada
    }

}
// En esta clase de tipo interfaz dejo la firma de los métodos, es como un contrato