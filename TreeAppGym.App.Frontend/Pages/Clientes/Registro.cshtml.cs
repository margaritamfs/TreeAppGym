using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TreeAppGym.App.Persistencia;
using TreeAppGym.App.Dominio;

namespace TreeAppGym.App.Frontend.Pages
{
    public class RegistroModel : PageModel
    {
        private readonly IRepositorioCliente repositorioCliente;

        [BindProperty]
        public Cliente Cliente  { get; set; } 

        public RegistroModel()
        {
            this.repositorioCliente = new RepositorioCliente(new TreeAppGym.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            repositorioCliente.CrearCliente(Cliente);
            return Page();
        }
    }
}
