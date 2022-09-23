using System;
using TreeAppGym.App.Dominio;
using TreeAppGym.App.Persistencia;
using System.Collections.Generic;

namespace TreeAppGym.App.Consola
{
    class Program
    {
        private static IRepositorioPlanNutricional _repoPlanNutricional =new RepositorioPlanNutricional(new Persistencia.AppContext());
        private static IRepositorioCliente _repoCliente = new RepositorioCliente(new Persistencia.AppContext());
        //Coloco un objeto que me permite llamar a cada uno de los métodos CRUD
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Entity Framework!");
            AdicionarPlanNutricional();
            //CRUD Clase Cliente
            var cliente = crearCliente();
            Console.WriteLine("Cliente Creado..");
            Console.WriteLine("Genero.."+(Genero)0);
            Console.WriteLine("Genero.."+Genero.masculino);

            foreach (int i in Enum.GetValues(typeof(Genero)))  
            {  
            Console.WriteLine($" {(Genero)i}" );  
            }  


           // ConsultarCliente(cliente.Id);
           //ConsultarClientes();
           // ActualizarCliente(cliente);
          //  EliminarCliente(cliente.Id);

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
        private static Cliente crearCliente()
        {
            var cliente = new Cliente
            {
                Nombres = "Nario",
                Apellidos = "Quintana",
                Edad = 25,
                Telefono = "3043043041",
                Direccion = "Av Regional #13-33",
                Genero = (Genero)0
                
            };
            return _repoCliente.CrearCliente(cliente);
        }
        private static void ConsultarCliente(int idCliente)
        {
            var cliente = _repoCliente.ConsultarCliente(idCliente);
             if (cliente == null)
             {
                Console.WriteLine("Cliente no encontrado..");
             }else
             {
                Console.WriteLine("Cliente encontrado con id : "+cliente.Id +" - Nombre "+cliente.Nombres);
             }
        }
        private static void ConsultarClientes()
        {
            IEnumerable<Cliente> clientes = _repoCliente.ConsultarClientes();
            Console.WriteLine("Clientes encontrados..");
            foreach (var cliente in clientes)
            {
                Console.WriteLine("Id Cliente : "+cliente.Id +" - Nombre "+cliente.Nombres);         
            }

        }
        private static void ActualizarCliente(Cliente cliente)
        {
            Console.WriteLine("Cliente actual - ID: " + cliente.Id + " - Nombre: "+cliente.Nombres);
            var clienteDatos = new Cliente
            {
                Id = cliente.Id,
                Nombres = "Luisa",
                Apellidos = "Soler",
                Edad = 26,
                Telefono = "3023023021",
                Direccion = "Av Regional #12-34",
                Genero = Genero.femenino
                
            };
            Cliente clienteActualizado = _repoCliente.ActualizarCliente(clienteDatos);
            Console.WriteLine("Cliente actualizado - ID: " + clienteActualizado.Id + " - Nombre: "+clienteActualizado.Nombres);
        }
        private static void EliminarCliente(int idCliente)
        {
            _repoCliente.EliminarCliente(idCliente);
            Console.WriteLine("Cliente eliminado con id : "+idCliente);
        }

    }
}
