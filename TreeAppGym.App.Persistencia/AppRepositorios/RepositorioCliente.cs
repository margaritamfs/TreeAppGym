using System;
using TreeAppGym.App.Dominio;
using System.Linq;
using System.Collections.Generic;


namespace TreeAppGym.App.Persistencia
{

    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly AppContext _appContext;

        public RepositorioCliente(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public Cliente CrearCliente(Cliente cliente)
        {
            var clienteAdicionado = _appContext.Clientes.Add(cliente);
            _appContext.SaveChanges();
            return clienteAdicionado.Entity;
        }

        public Cliente ConsultarCliente(int idCliente)
        {

            return _appContext.Clientes.FirstOrDefault(c => c.Id == idCliente);

        }

        public Cliente ConsultarClientePorEmail(string email)
        {
            Console.WriteLine("email.."+email);
            return _appContext.Clientes.FirstOrDefault(c => c.Email == email);

        }

        public IEnumerable<Cliente> ConsultarClientes()
        {
            return _appContext.Clientes;
        }

        public Cliente ActualizarCliente(Cliente cliente)
        {

            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(c => c.Id == cliente.Id);
            if (clienteEncontrado != null)
            {
                clienteEncontrado.Nombres = cliente.Nombres;
                clienteEncontrado.Apellidos = cliente.Apellidos;
                clienteEncontrado.Edad = cliente.Edad;
                clienteEncontrado.Telefono = cliente.Telefono;
                clienteEncontrado.Direccion = cliente.Direccion;
                clienteEncontrado.Genero = cliente.Genero;
                _appContext.SaveChanges();
            }
            return clienteEncontrado;

        }

        public void EliminarCliente(int idCliente)
        {
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(c => c.Id == idCliente);
            if (clienteEncontrado == null)
                return;
            _appContext.Clientes.Remove(clienteEncontrado);
            _appContext.SaveChanges();
        }

        public string ConsultarNombrePorEmail(string email)
        {
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(c => c.Email == email);
            if (clienteEncontrado == null)
              return "Gym "+email;
            else
             return clienteEncontrado.Nombres + " " + clienteEncontrado.Apellidos;
        }

    }

}