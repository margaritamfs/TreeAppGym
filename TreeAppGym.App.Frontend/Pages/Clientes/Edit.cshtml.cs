using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TreeAppGym.App.Dominio;
using TreeAppGym.App.Persistencia;

namespace TreeAppGym.App.Frontend.Pages
{


    public class EditModel : PageModel
    {

        private readonly IRepositorioCliente _repoClientes;

        [BindProperty]
        public Cliente Cliente  { get; set; }

        public EditModel()
        {
            _repoClientes = new RepositorioCliente(new Persistencia.AppContext());
        }


        public IActionResult OnGet(string userName)
        {
            Console.WriteLine("userName.."+userName);
            if (userName != null)
            {
                Cliente = _repoClientes.ConsultarClientePorEmail(userName);
            }
            if (Cliente == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

        public IActionResult OnPost()
        {
            Console.WriteLine("Cliente.Id.."+Cliente.Id);
            if(Cliente.Id>0)
            {
              Cliente = _repoClientes.ActualizarCliente(Cliente);
            }
            return Page();
        }
    }
}
