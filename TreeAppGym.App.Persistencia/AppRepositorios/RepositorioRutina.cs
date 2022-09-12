using TreeAppGym.App.Dominio;
using System.Linq;
//permite trabajar BD, asì puedo hacer las tablas
using System.Collections.Generic;
//permite leer los namespace

namespace TreeAppGym.App.Persistencia
{

    public class RepositorioRutina : IRepositorioRutina
    {
        private readonly AppContext _appContext;

        public RepositorioRutina(AppContext appContext)
        {
            this._appContext = appContext;
            // ojo este appContext es la conexión a la BD
        }

        public Rutina CrearRutina(Rutina Rutina)
        {
            var RutinaAdicionado = _appContext.Rutina.Add(Rutina); 
            _appContext.SaveChanges();
            // aqui guardo los cambios en la BD
            return RutinaAdicionado.Entity;
            // me lo envía como una entidad es decir como un objeto
        }

        public Rutina ConsultarRutina(int idRutina)
        {
            return _appContext.Rutina.FirstOrDefault(r => r.Id == idRutina);  
            //doble == porque estoy comparando enteros
        }

        public IEnumerable<Rutina> ConsultarRutina()
        {
            return _appContext.Rutina;
        }

        public Rutina ActualizarRutina(Rutina Rutina)
        {

            var RutinaEncontrado = _appContext.Rutina.FirstOrDefault(r => r.Id == Rutina.Id);
            if (RutinaEncontrado != null)
            {
                RutinaEncontrado.Categoria = Rutina.Categoria;
                RutinaEncontrado.Descripcion = Rutina.Descripcion;
                RutinaEncontrado.Imagen = Rutina.Imagen;
                
                _appContext.SaveChanges();
            }
            return RutinaEncontrado;

        }

        public void EliminarRutina(int idRutina)
        {
            var RutinaEncontrado = _appContext.Rutina.FirstOrDefault(r => r.Id == idRutina);
            if (RutinaEncontrado == null)
            return;
            _appContext.Rutina.Remove(RutinaEncontrado);
            _appContext.SaveChanges();
        }

    }


}