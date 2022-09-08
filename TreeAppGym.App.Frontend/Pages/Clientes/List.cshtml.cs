using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using TreeAppGym.App.Persistencia;
using TreeAppGym.App.Dominio;


namespace TreeAppGym.App.Frontend.Pages
{
    public class ListModel : PageModel
    {


        private readonly IRepositorioCliente repositorioCliente;
        public IEnumerable<Cliente> Clientes {get;set;}

        public ListModel()
        {
            this.repositorioCliente = new RepositorioCliente(new TreeAppGym.App.Persistencia.AppContext());
        }

        public void OnGet()
        {
            Clientes = repositorioCliente.ConsultarClientes();
            
        }
    }
}
