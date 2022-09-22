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
                //clienteEncontrado.Email = cliente.Email;
                clienteEncontrado.Edad = cliente.Edad;
                clienteEncontrado.Telefono = cliente.Telefono;
                clienteEncontrado.Direccion = cliente.Direccion;
                //clienteEncontrado.Contraseña = cliente.Contraseña;
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

    }

}