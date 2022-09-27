using TreeAppGym.App.Dominio;
// para que pueda leer donde está la entidad PlanNutricional
using System.Collections.Generic;
// este using es para que no me marque error con las listas numeradas
// en este paquete se encuentra todo lo que tiene que ver con listas

namespace TreeAppGym.App.Persistencia{

    public interface IRepositorioPlanNutricional{

        PlanNutricional CrearPlanNutricional(PlanNutricional PlanNutricional);

        PlanNutricional ConsultarPlanNutricional(int idPlanNutricional);
        // aqui quiero que me retorne todas las listas de planes nutricionales
        IEnumerable<PlanNutricional> ConsultarPlanNutricionales();
        
        PlanNutricional ActualizarPlanNutricional(PlanNutricional PlanNutricional);

        void EliminarPlanNutricional(int idPlanNutricional);
        // vacío porque no necesito que al eliminar me retorne nada
    }


}
// En esta clase de tipo interfaz dejo la firma de los métodos, es como un contrato