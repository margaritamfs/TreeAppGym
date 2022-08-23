using System;

namespace TreeAppGym.App.Dominio
{
    public class TreeAppGym
    {
        public int Id {get; set;} 
        public int IdCliente {get; set;}
        public int IdRutina {get; set;}
        public int IdPlanNutricional {get; set;}
        public DateTime Fecha {get; set;}
        public Estado Estado {get; set;}
        public float Peso {get; set;}
    }
}
