using System;

namespace TreeAppGym.App.Dominio
{
    public class PlanNutricional
    {
       public int Id {get; set;}
       public Categoria Categoria {get; set;}
       public String Descripcion {get; set;}
       public Object Imagen {get; set;}
    }
}