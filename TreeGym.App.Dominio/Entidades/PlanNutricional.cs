using System;

namespace TreeGym.App.Dominio
{
    public class PlanNutricional
    {
        public float Id {get;set;}
        public CategoriaNutricion CategoriaNutricion {get;set;}
        public string Descripcion {get;set;}
        public string Imagen {get;set;}
    }
}