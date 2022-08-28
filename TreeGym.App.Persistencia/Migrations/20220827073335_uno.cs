using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TreeGym.App.Persistencia.Migrations
{
    public partial class uno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<float>(type: "real", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gyms",
                columns: table => new
                {
                    Id = table.Column<float>(type: "real", nullable: false),
                    IdCliente = table.Column<float>(type: "real", nullable: false),
                    IdRutina = table.Column<float>(type: "real", nullable: false),
                    IdPlanNutricional = table.Column<float>(type: "real", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Peso = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gyms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlanesNutricionales",
                columns: table => new
                {
                    Id = table.Column<float>(type: "real", nullable: false),
                    CategoriaNutricion = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanesNutricionales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rutinas",
                columns: table => new
                {
                    Id = table.Column<float>(type: "real", nullable: false),
                    CategoriaRutina = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rutinas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Gyms");

            migrationBuilder.DropTable(
                name: "PlanesNutricionales");

            migrationBuilder.DropTable(
                name: "Rutinas");
        }
    }
}
