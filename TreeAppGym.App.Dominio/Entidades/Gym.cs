using System;

namespace TreeAppGym.App.Dominio
{
    public class Gym
    {
        public int Id {get; set;} 
        public Clientes Clientes {get; set;}
        public Rutina Rutina {get; set;}
        public PlanNutricional PlanNutricional {get; set;}
        public DateTime Fecha {get; set;}
        public Estado Estado {get; set;}
        public float Peso {get; set;}
    }
}
