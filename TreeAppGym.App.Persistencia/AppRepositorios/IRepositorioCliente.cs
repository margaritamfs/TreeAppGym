using TreeAppGym.App.Dominio;
using System.Collections.Generic;

namespace TreeAppGym.App.Persistencia{

    public interface IRepositorioCliente{

        Cliente CrearCliente(Cliente cliente);

        Cliente ConsultarCliente(int idCliente);

        IEnumerable<Cliente> ConsultarClientes();
        
        Cliente ActualizarCliente(Cliente cliente);

        void EliminarCliente(int idCliente);

        string ConsultarNombrePorEmail(string email);    

        Cliente ConsultarClientePorEmail(string email);    
    }


}