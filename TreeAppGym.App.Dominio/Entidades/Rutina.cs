
using System;

    namespace TreeAppGym.App.Dominio
    {
        public class Rutina
        {
            public int Id {get; set;} 
            public Categoria Categoria {get; set;}
            public string Descripcion {get; set;}
            public string Imagen {get; set;}
            public string Video {get; set;}
        }
    }
