using TreeAppGym.App.Dominio;
using TreeAppGym.App.persistencia;
using System.Collections.Generic;

namespace TreeAppGym.App.Consola
{
    class Program
    {
        private  static IRepositorioRutina _repoRutina =new RepositorioRutina(new persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AdicionarClientes();
        }
        private static void AdicionarRutina()
        {
            var Rutina = new Rutina
            {
                Categoria=Categoria.avanzada,
                Descripcion="Rutina Basica",
                Imagen="url",
                Video="Url",
                
            };

            _repoClientes.CrearClientes(Clientes);
        }
    }
}

