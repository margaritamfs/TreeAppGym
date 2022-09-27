using TreeAppGym.App.Dominio;
using System.Linq;
using System.Collections.Generic;


namespace TreeAppGym.App.Persistencia
{

    public class RepositorioPlanNutricional : IRepositorioPlanNutricional
    {
        private readonly AppContext _appContext;

        public RepositorioPlanNutricional(AppContext appContext)
        {
            this._appContext = appContext;
            // ojo este appContext es la conexión a la BD
        }

        public PlanNutricional CrearPlanNutricional(PlanNutricional PlanNutricional)
        {
            var PlanNutricionalAdicionado = _appContext.PlanNutricional.Add(PlanNutricional);
            _appContext.SaveChanges();
            // aqui guardo los cambios en la BD
            return PlanNutricionalAdicionado.Entity;
            // me lo envía como una entidad es decir como un objeto
        }

        public PlanNutricional ConsultarPlanNutricional(int idPlanNutricional)
        {
            return _appContext.PlanNutricional.FirstOrDefault(pn => pn.Id == idPlanNutricional);
        
        }

        public IEnumerable<PlanNutricional> ConsultarPlanNutricionales()
        {
            return _appContext.PlanNutricional;
        }

        public PlanNutricional ActualizarPlanNutricional(PlanNutricional PlanNutricional)
        {

            var PlanNutricionalEncontrado = _appContext.PlanNutricional.FirstOrDefault(pn => pn.Id == PlanNutricional.Id);
            if (PlanNutricionalEncontrado != null)
            {
                PlanNutricionalEncontrado.Categoria = PlanNutricional.Categoria;
                PlanNutricionalEncontrado.Descripcion = PlanNutricional.Descripcion;
                PlanNutricionalEncontrado.Imagen = PlanNutricional.Imagen;
                
                _appContext.SaveChanges();
            }
            return PlanNutricionalEncontrado;

        }

        public void EliminarPlanNutricional(int idPlanNutricional)
        {
            var PlanNutricionalEncontrado = _appContext.PlanNutricional.FirstOrDefault(pn => pn.Id == idPlanNutricional);
            if (PlanNutricionalEncontrado == null)
            return;
            _appContext.PlanNutricional.Remove(PlanNutricionalEncontrado);
            _appContext.SaveChanges();
        }

    }

}