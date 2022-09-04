using Microsoft.EntityFrameworkCore.Migrations;

namespace TreeAppGym.App.Persistencia.Migrations
{
    public partial class entityclientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gym_Clientes_ClientesId",
                table: "Gym");

            migrationBuilder.DropForeignKey(
                name: "FK_Gym_PlanNutricional_PlanNutricionalId",
                table: "Gym");

            migrationBuilder.DropForeignKey(
                name: "FK_Gym_Rutina_RutinaId",
                table: "Gym");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rutina",
                table: "Rutina");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gym",
                table: "Gym");

            migrationBuilder.RenameTable(
                name: "Rutina",
                newName: "Rutinas");

            migrationBuilder.RenameTable(
                name: "Gym",
                newName: "Gyms");

            migrationBuilder.RenameColumn(
                name: "ClientesId",
                table: "Gyms",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Gym_RutinaId",
                table: "Gyms",
                newName: "IX_Gyms_RutinaId");

            migrationBuilder.RenameIndex(
                name: "IX_Gym_PlanNutricionalId",
                table: "Gyms",
                newName: "IX_Gyms_PlanNutricionalId");

            migrationBuilder.RenameIndex(
                name: "IX_Gym_ClientesId",
                table: "Gyms",
                newName: "IX_Gyms_ClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rutinas",
                table: "Rutinas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gyms",
                table: "Gyms",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Gyms_Clientes_ClienteId",
                table: "Gyms",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gyms_PlanNutricional_PlanNutricionalId",
                table: "Gyms",
                column: "PlanNutricionalId",
                principalTable: "PlanNutricional",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gyms_Rutinas_RutinaId",
                table: "Gyms",
                column: "RutinaId",
                principalTable: "Rutinas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gyms_Clientes_ClienteId",
                table: "Gyms");

            migrationBuilder.DropForeignKey(
                name: "FK_Gyms_PlanNutricional_PlanNutricionalId",
                table: "Gyms");

            migrationBuilder.DropForeignKey(
                name: "FK_Gyms_Rutinas_RutinaId",
                table: "Gyms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rutinas",
                table: "Rutinas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gyms",
                table: "Gyms");

            migrationBuilder.RenameTable(
                name: "Rutinas",
                newName: "Rutina");

            migrationBuilder.RenameTable(
                name: "Gyms",
                newName: "Gym");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Gym",
                newName: "ClientesId");

            migrationBuilder.RenameIndex(
                name: "IX_Gyms_RutinaId",
                table: "Gym",
                newName: "IX_Gym_RutinaId");

            migrationBuilder.RenameIndex(
                name: "IX_Gyms_PlanNutricionalId",
                table: "Gym",
                newName: "IX_Gym_PlanNutricionalId");

            migrationBuilder.RenameIndex(
                name: "IX_Gyms_ClienteId",
                table: "Gym",
                newName: "IX_Gym_ClientesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rutina",
                table: "Rutina",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gym",
                table: "Gym",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Gym_Clientes_ClientesId",
                table: "Gym",
                column: "ClientesId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gym_PlanNutricional_PlanNutricionalId",
                table: "Gym",
                column: "PlanNutricionalId",
                principalTable: "PlanNutricional",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gym_Rutina_RutinaId",
                table: "Gym",
                column: "RutinaId",
                principalTable: "Rutina",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
