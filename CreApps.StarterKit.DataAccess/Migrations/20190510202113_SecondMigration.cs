using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CreApps.StarterKit.DataAccess.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "Ticket",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Ticket",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Bodega",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    NombreBodega = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bodega", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    NombreCliente = table.Column<string>(nullable: true),
                    DocumentoCliente = table.Column<string>(nullable: true),
                    DireccionCliente = table.Column<string>(nullable: true),
                    TelefonoCliente = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    NombreEstado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoContenido",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    NombreTipoContenido = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoContenido", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ubicacion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    UbicacionCilindro = table.Column<string>(nullable: true),
                    BodegaId = table.Column<int>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ubicacion_Bodega_BodegaId",
                        column: x => x.BodegaId,
                        principalTable: "Bodega",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ubicacion_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cilindro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    Serial = table.Column<string>(nullable: true),
                    Tamaño = table.Column<decimal>(nullable: false),
                    FechaDeTraslado = table.Column<DateTime>(nullable: false),
                    FechaHoy = table.Column<DateTime>(nullable: false),
                    MostrarUbicacion = table.Column<string>(nullable: true),
                    TipoContenidoId = table.Column<int>(nullable: false),
                    EstadoId = table.Column<int>(nullable: false),
                    UbicacionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cilindro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cilindro_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cilindro_TipoContenido_TipoContenidoId",
                        column: x => x.TipoContenidoId,
                        principalTable: "TipoContenido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cilindro_Ubicacion_UbicacionId",
                        column: x => x.UbicacionId,
                        principalTable: "Ubicacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bodega",
                columns: new[] { "Id", "CreatedOn", "NombreBodega", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 5, 10, 15, 21, 12, 259, DateTimeKind.Local).AddTicks(4831), "Bodega LLena", new DateTime(2019, 5, 10, 15, 21, 12, 259, DateTimeKind.Local).AddTicks(4835) },
                    { 2, new DateTime(2019, 5, 10, 15, 21, 12, 259, DateTimeKind.Local).AddTicks(5415), "Bodega Vacia", new DateTime(2019, 5, 10, 15, 21, 12, 259, DateTimeKind.Local).AddTicks(5415) },
                    { 3, new DateTime(2019, 5, 10, 15, 21, 12, 259, DateTimeKind.Local).AddTicks(5420), "Oxifull Bogota", new DateTime(2019, 5, 10, 15, 21, 12, 259, DateTimeKind.Local).AddTicks(5424) }
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "Id", "CreatedOn", "DireccionCliente", "DocumentoCliente", "NombreCliente", "TelefonoCliente", "UpdatedOn" },
                values: new object[] { 1, new DateTime(2019, 5, 10, 15, 21, 12, 259, DateTimeKind.Local).AddTicks(7886), "Calle 38a #16-50", "1118571567", "Ronall Otalora", "3114992296", new DateTime(2019, 5, 10, 15, 21, 12, 259, DateTimeKind.Local).AddTicks(7886) });

            migrationBuilder.InsertData(
                table: "Estado",
                columns: new[] { "Id", "CreatedOn", "NombreEstado", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 5, 10, 15, 21, 12, 259, DateTimeKind.Local).AddTicks(2766), "LLeno", new DateTime(2019, 5, 10, 15, 21, 12, 259, DateTimeKind.Local).AddTicks(2774) },
                    { 2, new DateTime(2019, 5, 10, 15, 21, 12, 259, DateTimeKind.Local).AddTicks(3508), "Vacio", new DateTime(2019, 5, 10, 15, 21, 12, 259, DateTimeKind.Local).AddTicks(3512) },
                    { 3, new DateTime(2019, 5, 10, 15, 21, 12, 259, DateTimeKind.Local).AddTicks(3521), "Danañado", new DateTime(2019, 5, 10, 15, 21, 12, 259, DateTimeKind.Local).AddTicks(3521) },
                    { 4, new DateTime(2019, 5, 10, 15, 21, 12, 259, DateTimeKind.Local).AddTicks(3521), "En Mantenimiento", new DateTime(2019, 5, 10, 15, 21, 12, 259, DateTimeKind.Local).AddTicks(3521) }
                });

            migrationBuilder.UpdateData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 5, 10, 15, 21, 12, 238, DateTimeKind.Local).AddTicks(1660), new DateTime(2019, 5, 10, 15, 21, 12, 238, DateTimeKind.Local).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 5, 10, 15, 21, 12, 238, DateTimeKind.Local).AddTicks(2261), new DateTime(2019, 5, 10, 15, 21, 12, 238, DateTimeKind.Local).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 5, 10, 15, 21, 12, 238, DateTimeKind.Local).AddTicks(2270), new DateTime(2019, 5, 10, 15, 21, 12, 238, DateTimeKind.Local).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 5, 10, 15, 21, 12, 238, DateTimeKind.Local).AddTicks(2270), new DateTime(2019, 5, 10, 15, 21, 12, 238, DateTimeKind.Local).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 5, 10, 15, 21, 12, 238, DateTimeKind.Local).AddTicks(3379), new DateTime(2019, 5, 10, 15, 21, 12, 238, DateTimeKind.Local).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 5, 10, 15, 21, 12, 238, DateTimeKind.Local).AddTicks(3891), new DateTime(2019, 5, 10, 15, 21, 12, 238, DateTimeKind.Local).AddTicks(3895) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 5, 10, 15, 21, 12, 238, DateTimeKind.Local).AddTicks(3900), new DateTime(2019, 5, 10, 15, 21, 12, 238, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 5, 10, 15, 21, 12, 238, DateTimeKind.Local).AddTicks(3900), new DateTime(2019, 5, 10, 15, 21, 12, 238, DateTimeKind.Local).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 5, 10, 15, 21, 12, 238, DateTimeKind.Local).AddTicks(3904), new DateTime(2019, 5, 10, 15, 21, 12, 238, DateTimeKind.Local).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 5, 10, 15, 21, 12, 238, DateTimeKind.Local).AddTicks(4817), new DateTime(2019, 5, 10, 15, 21, 12, 238, DateTimeKind.Local).AddTicks(4821) });

            migrationBuilder.UpdateData(
                table: "TicketType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 5, 10, 15, 21, 12, 236, DateTimeKind.Local).AddTicks(9449), new DateTime(2019, 5, 10, 15, 21, 12, 237, DateTimeKind.Local).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "TicketType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 5, 10, 15, 21, 12, 237, DateTimeKind.Local).AddTicks(7619), new DateTime(2019, 5, 10, 15, 21, 12, 237, DateTimeKind.Local).AddTicks(7628) });

            migrationBuilder.UpdateData(
                table: "TicketType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 5, 10, 15, 21, 12, 237, DateTimeKind.Local).AddTicks(7636), new DateTime(2019, 5, 10, 15, 21, 12, 237, DateTimeKind.Local).AddTicks(7636) });

            migrationBuilder.InsertData(
                table: "TipoContenido",
                columns: new[] { "Id", "CreatedOn", "NombreTipoContenido", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 5, 10, 15, 21, 12, 259, DateTimeKind.Local).AddTicks(6406), "Oxigeno", new DateTime(2019, 5, 10, 15, 21, 12, 259, DateTimeKind.Local).AddTicks(6406) },
                    { 2, new DateTime(2019, 5, 10, 15, 21, 12, 259, DateTimeKind.Local).AddTicks(6965), "Acetileno", new DateTime(2019, 5, 10, 15, 21, 12, 259, DateTimeKind.Local).AddTicks(6969) },
                    { 3, new DateTime(2019, 5, 10, 15, 21, 12, 259, DateTimeKind.Local).AddTicks(6973), "Mezcla", new DateTime(2019, 5, 10, 15, 21, 12, 259, DateTimeKind.Local).AddTicks(6973) },
                    { 4, new DateTime(2019, 5, 10, 15, 21, 12, 259, DateTimeKind.Local).AddTicks(6973), "Nitrogeno", new DateTime(2019, 5, 10, 15, 21, 12, 259, DateTimeKind.Local).AddTicks(6977) },
                    { 5, new DateTime(2019, 5, 10, 15, 21, 12, 259, DateTimeKind.Local).AddTicks(6977), "Argon", new DateTime(2019, 5, 10, 15, 21, 12, 259, DateTimeKind.Local).AddTicks(6977) },
                    { 6, new DateTime(2019, 5, 10, 15, 21, 12, 259, DateTimeKind.Local).AddTicks(6977), "Dioxido De Carbono", new DateTime(2019, 5, 10, 15, 21, 12, 259, DateTimeKind.Local).AddTicks(6977) }
                });

            migrationBuilder.InsertData(
                table: "Ubicacion",
                columns: new[] { "Id", "BodegaId", "ClienteId", "CreatedOn", "UbicacionCilindro", "UpdatedOn" },
                values: new object[] { 1, 1, 1, new DateTime(2019, 5, 10, 15, 21, 12, 260, DateTimeKind.Local).AddTicks(745), "Bodega", new DateTime(2019, 5, 10, 15, 21, 12, 260, DateTimeKind.Local).AddTicks(745) });

            migrationBuilder.InsertData(
                table: "Ubicacion",
                columns: new[] { "Id", "BodegaId", "ClienteId", "CreatedOn", "UbicacionCilindro", "UpdatedOn" },
                values: new object[] { 2, 1, 1, new DateTime(2019, 5, 10, 15, 21, 12, 260, DateTimeKind.Local).AddTicks(2085), "Cliente", new DateTime(2019, 5, 10, 15, 21, 12, 260, DateTimeKind.Local).AddTicks(2085) });

            migrationBuilder.CreateIndex(
                name: "IX_Cilindro_EstadoId",
                table: "Cilindro",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cilindro_TipoContenidoId",
                table: "Cilindro",
                column: "TipoContenidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cilindro_UbicacionId",
                table: "Cilindro",
                column: "UbicacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Ubicacion_BodegaId",
                table: "Ubicacion",
                column: "BodegaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ubicacion_ClienteId",
                table: "Ubicacion",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cilindro");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropTable(
                name: "TipoContenido");

            migrationBuilder.DropTable(
                name: "Ubicacion");

            migrationBuilder.DropTable(
                name: "Bodega");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "Ticket",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Ticket",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(3526), new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(4296), new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(4305), new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(4307), new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(5329), new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(6021), new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(6027), new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(6029), new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(6031), new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(6970), new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "TicketType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 49, 1, 960, DateTimeKind.Local).AddTicks(2227), new DateTime(2019, 4, 17, 11, 49, 1, 961, DateTimeKind.Local).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "TicketType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 49, 1, 961, DateTimeKind.Local).AddTicks(4315), new DateTime(2019, 4, 17, 11, 49, 1, 961, DateTimeKind.Local).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "TicketType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 49, 1, 961, DateTimeKind.Local).AddTicks(4331), new DateTime(2019, 4, 17, 11, 49, 1, 961, DateTimeKind.Local).AddTicks(4331) });
        }
    }
}
