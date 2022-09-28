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

        [BindProperty]
        public AtributosModel Atributos { get; set; }

        [BindProperty]
        public RutinaModel RutinaSelected { get; set; }

        public class RutinaModel
        {

            public int Id {get; set;} 
            public string Descripcion {get; set;}
            public bool Selected {get; set;}
        }

        public class AtributosModel
        {
            public double Peso {get; set;} 
            public double Estatura {get; set;}
        }

        public AsignarModel()
       {
            this._repoRutinas=new RepositorioRutina(new Persistencia.AppContext());
            this._repoNutricional=new RepositorioPlanNutricional(new Persistencia.AppContext());
       }

        public void OnGet()
        {
            //Rutinas = _repoRutinas.ConsultarRutinas();
            //Nutricionales = _repoNutricional.ConsultarPlanNutricionales();
        }

        public IActionResult OnPost()
        {
            
            Console.WriteLine("Peso.."+Atributos.Peso);
            Console.WriteLine("Estatura.."+Atributos.Estatura);
            double IMC = (Atributos.Peso / (Math.Pow(Atributos.Estatura, 2)))*1000;
            Console.WriteLine("IMC.."+IMC);
            Rutinas = _repoRutinas.ConsultarRutinas();   
            Nutricionales = _repoNutricional.ConsultarPlanNutricionales(); 
            if(IMC < 1.85){
                var RutinaEncontrado = Rutinas.FirstOrDefault(r => r.Categoria == Categoria.basica);
                RutinaSelected.Id = RutinaEncontrado.Id;
                RutinaSelected.Descripcion = RutinaEncontrado.Descripcion;
                RutinaSelected.Selected = true;
            }
            if(IMC > 1.86 && IMC < 2.49){
                var RutinaEncontrado = Rutinas.FirstOrDefault(r => r.Categoria == Categoria.intermedia);
                RutinaSelected.Id = RutinaEncontrado.Id;
                RutinaSelected.Descripcion = RutinaEncontrado.Descripcion;
                RutinaSelected.Selected = true;
            }
            if(IMC > 2.5){
                var RutinaEncontrado = Rutinas.FirstOrDefault(r => r.Categoria == Categoria.avanzada);
                RutinaSelected.Id = RutinaEncontrado.Id;
                RutinaSelected.Descripcion = RutinaEncontrado.Descripcion;
                RutinaSelected.Selected = true;
            }
            return Page();
        }
    }
}
