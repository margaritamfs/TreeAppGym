using TreeAppGym.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace TreeAppGym.App.persistencia
{
     public class RepositorioRutina : IRepositorioRutina
     {
        private readonly AppContext _appContext;

        public RepositorioRutina(AppContext appContext)
        {
             this._appContext = appContext;
             
        }
      
        public Rutina CrearRutina(Rutina Rutina)
        {
           var RutinaAdicionado = _appContext.Rutina.Add(Rutina);
            _appContext.SaveChanges();
            return RutinaAdicionado.Entity;
        }
         
         public Rutina ConsultarRutina(int idRutina)
         {
            return _appContext.Rutina.FirstOrDefault(c => c.Id == idRutina);
         }
       
         public IEnumerable<Rutina> ConsultarRutina()
         {
            return _appContext.Rutina;
         }
          
         public Rutina ActualizarRutina(Rutina Rutina)
         {
            var RutinaEncontrado = _appContext.Rutina.FirstOrDefault(c => c.Id == Rutina.Id);
            if (RutinaEncontrado != null)
            {
              RutinaEncontrado.Categoria = Rutina.Categoria;
              RutinaEncontrado.Descripcion = Rutina.Descripcion;
              RutinaEncontrado.Imagen = Rutina.Imagen;
              RutinaEncontrado.Video = Rutina.Video;
            }
            return RutinaEncontrado;
         }  

          public void EliminarRutina(int idRutina)
          {
            var RutinaEncontrado = _appContext.Rutina.FirstOrDefault(c => c.Id == idRutina);
            if (RutinaEncontrado == null)
                return;
            _appContext.Rutina.Remove(RutinaEncontrado);
            _appContext.SaveChanges();
          }
      }

}