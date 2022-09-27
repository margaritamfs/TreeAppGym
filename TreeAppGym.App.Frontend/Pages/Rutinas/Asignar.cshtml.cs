using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using TreeAppGym.App.Dominio;
using TreeAppGym.App.Persistencia;

namespace TreeAppGym.App.Frontend.Pages
{
    //[Authorize]
    public class AsignarModel : PageModel
    {
        private readonly IRepositorioRutina _repoRutinas;

        private readonly IRepositorioPlanNutricional _repoNutricional;

        public IEnumerable<Rutina> Rutinas {get;set;}
        public IEnumerable<PlanNutricional> Nutricionales {get;set;}

        public AsignarModel()
       {
            this._repoRutinas=new RepositorioRutina(new Persistencia.AppContext());
            this._repoNutricional=new RepositorioPlanNutricional(new Persistencia.AppContext());
       }

        public void OnGet()
        {
            Rutinas = _repoRutinas.ConsultarRutinas();
            Nutricionales = _repoNutricional.ConsultarPlanNutricionales();
        }
    }
}
