using System;
using System.ComponentModel.DataAnnotations;
namespace TreeAppGym.App.Dominio
{
    public class Cliente
    {
      public int Id {get; set;}
      [Required(ErrorMessage = "El campo es requerido"),StringLength(50)]
      public string Nombres {get; set;}
      [Required(ErrorMessage = "El campo es requerido"),StringLength(50)]
      public string Apellidos {get; set;}
      public int Edad {get; set;}
      public string Telefono {get; set;}
      public string Direccion {get; set;}
      public Genero Genero {get; set;}

    }
}
