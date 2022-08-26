
using System;

    namespace TreeAppGym.App.Dominio
    {
        public class Rutina
        {
            public int Id {get; set;} 
            public Categoria Categoria {get; set;}
            public String Descripcion {get; set;}
            public Object Imagen {get; set;}
            public Object Video {get; set;}
        }
    }
