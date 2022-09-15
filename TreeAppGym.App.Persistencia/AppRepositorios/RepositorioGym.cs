using TreeAppGym.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace TreeAppGym.App.Persistencia
{

    public class RepositorioGym : IRepositorioGym
    {
        private readonly AppContext _appContext;

        public RepositorioGym(AppContext appContext)
        {
            this._appContext = appContext;            
        }

        public Gym CrearGym(Gym gym)
        {
            var gymAdicionado = _appContext.Gyms.Add(gym);
            _appContext.SaveChanges();            
            return gymAdicionado.Entity;           
        }
       
        public Gym ConsultarGym(int idGym)
        {
            return _appContext.Gyms.FirstOrDefault(p => p.Id == idGym);        
        }

        public IEnumerable<Gym> ConsultarGyms()
        {
            return _appContext.Gyms;
        }

        public Gym ActualizarGym(Gym gym)
        {

            var gymEncontrado = _appContext.Gyms.FirstOrDefault(p => p.Id == gym.Id);
            if (gym != null)
            {
                gymEncontrado.Id = gym.Id;
                gymEncontrado.Peso = gym.Peso;
                gymEncontrado.Estado = gym.Estado;
                gymEncontrado.Fecha = gym.Fecha;
                gymEncontrado.Cliente = gym.Cliente;
                gymEncontrado.Rutina = gym.Rutina;
                gymEncontrado.PlanNutricional = gym.PlanNutricional;
                
                _appContext.SaveChanges();
            }
            return gymEncontrado;

        }

        public void EliminarGym(int idGym)
        {
            var gymEncontrado = _appContext.Gyms.FirstOrDefault(p => p.Id == idGym);
            if (gymEncontrado == null)
            return;
            _appContext.Gyms.Remove(gymEncontrado);
            _appContext.SaveChanges();
        }

    }

}