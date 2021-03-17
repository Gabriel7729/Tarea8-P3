using Microsoft.EntityFrameworkCore.Migrations;

namespace Tarea8_P3.Migrations
{
    public partial class BasedeDatosArreglada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "d");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "g");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "h");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "t");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Latitud", "Longitud", "apellido", "fecahDosis1", "fecahDosis2", "fechaNacimiento", "nombre", "provincia", "telefono", "tipoVacuna" },
                values: new object[] { "h", null, null, "ramirez", null, null, null, "Laptop", null, 10L, "This is a best gaming laptop" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Latitud", "Longitud", "apellido", "fecahDosis1", "fecahDosis2", "fechaNacimiento", "nombre", "provincia", "telefono", "tipoVacuna" },
                values: new object[] { "d", null, null, "ramirez", null, null, null, "Microsoft Office", null, 50L, "This is a Office Application" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Latitud", "Longitud", "apellido", "fecahDosis1", "fecahDosis2", "fechaNacimiento", "nombre", "provincia", "telefono", "tipoVacuna" },
                values: new object[] { "t", null, null, "ramirez", null, null, null, "Lazer Mouse", null, 20L, "The mouse that works on all surface" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Latitud", "Longitud", "apellido", "fecahDosis1", "fecahDosis2", "fechaNacimiento", "nombre", "provincia", "telefono", "tipoVacuna" },
                values: new object[] { "g", null, null, "ramirez", "f", "f", "a", "USB Storage", "c", 20L, "To store 256GB of data" });
        }
    }
}
