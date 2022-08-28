using System;

namespace TreeGym.App.Dominio
{
    public class Gym
    {
        public float Id {get;set;}
        public float IdCliente {get;set;}
        public float IdRutina {get;set;}
        public float IdPlanNutricional {get;set;}
        public DateTime Fecha {get;set;}
        public Estado Estado {get;set;}
        public float Peso {get;set;}
    }
}