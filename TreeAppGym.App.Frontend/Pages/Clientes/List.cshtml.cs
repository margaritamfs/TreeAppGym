using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TreeAppGym.App.Persistencia;
using TreeAppGym.App.Dominio;

namespace TreeAppGym.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
       // public string[] clientes = {"luis","jose","juan","maria"};

        //public List<string> ListaClientes {get;set;}

        private readonly IRepositorioCliente repositorioCliente;
        public IEnumerable<Cliente> Clientes {get;set;}

        public ListModel(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }

        public void OnGet()
        {
            //ListaClientes = new List<string>();
            //ListaClientes.AddRange(clientes);
            Clientes = repositorioCliente.ConsultarClientes();
            
        }
    }
}
