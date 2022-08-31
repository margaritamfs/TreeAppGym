using System;
using TreeAppGym.App.Dominio;
using TreeAppGym.App.Persistencia;

namespace TreeAppGym.App.Consola
{
    class Program
    {
        private static IRepositorioPlanNutricional _repoPlanNutricional =new RepositorioPlanNutricional(new Persistencia.AppContext());
        //Coloco un objeto que me permite llamar a cada uno de los métodos CRUD
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Entity Framework!");
            AdicionarPlanNutricional();
        }
        //Clase específica para crear el objeto PlanNutricional
        private static void AdicionarPlanNutricional()
        {
            var planNutricional = new PlanNutricional
            {
                Categoria=Categoria.basica,
                Descripcion="Alimentación saludable para principiantes",
                Imagen="123456"
                
            };
            _repoPlanNutricional.CrearPlanNutricional(planNutricional);
        }

    }
}
