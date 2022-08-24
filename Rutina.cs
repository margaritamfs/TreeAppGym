
using System;

    namespace TreeAppGym.App.Dominio
    {
        public class Rutina
        {
            public int Id {get; set;} 
            public Categoria Categoria {get; set;}
            public String Descripcion {get; set;}
            public String Imagen {get; set;}
            public String Video {get; set;}
        }
    }
