using Microsoft.EntityFrameworkCore.Migrations;

namespace MascotaFeliz.app.persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmpresaDb",
                columns: table => new
                {
                    Nit = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmpresa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DireccionEmpresa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TelefonoEmpresa = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaDb", x => x.Nit);
                });

            migrationBuilder.CreateTable(
                name: "TipoAnimal",
                columns: table => new
                {
                    IdTipoAnimal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAnimal", x => x.IdTipoAnimal);
                });

            migrationBuilder.CreateTable(
                name: "MascotaDb",
                columns: table => new
                {
                    IdMascota = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMascota = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ColorOjos = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ColorPiel = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Estatura = table.Column<int>(type: "int", nullable: false),
                    Peso = table.Column<int>(type: "int", nullable: false),
                    FrecuenciaCardiaca = table.Column<int>(type: "int", nullable: false),
                    FrecuenciaRespiratoria = table.Column<int>(type: "int", nullable: false),
                    IdAnimal = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MascotaDb", x => x.IdMascota);
                    table.ForeignKey(
                        name: "FK_MascotaDb_TipoAnimal_IdAnimal",
                        column: x => x.IdAnimal,
                        principalTable: "TipoAnimal",
                        principalColumn: "IdTipoAnimal",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicosDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMedico = table.Column<int>(type: "int", nullable: false),
                    TarjetaProfecional = table.Column<int>(type: "int", nullable: false),
                    Especialidad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IdAnimal = table.Column<int>(type: "int", nullable: true),
                    Nit = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicosDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicosDb_EmpresaDb_Nit",
                        column: x => x.Nit,
                        principalTable: "EmpresaDb",
                        principalColumn: "Nit",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicosDb_TipoAnimal_IdAnimal",
                        column: x => x.IdAnimal,
                        principalTable: "TipoAnimal",
                        principalColumn: "IdTipoAnimal",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SolicitudAtencionDb",
                columns: table => new
                {
                    IdSolicitudAtencion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreSolicitud = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaSolicitud = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DetalleSolicitud = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    IdMascota = table.Column<int>(type: "int", nullable: true),
                    IdAnimal = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudAtencionDb", x => x.IdSolicitudAtencion);
                    table.ForeignKey(
                        name: "FK_SolicitudAtencionDb_MascotaDb_IdMascota",
                        column: x => x.IdMascota,
                        principalTable: "MascotaDb",
                        principalColumn: "IdMascota",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SolicitudAtencionDb_TipoAnimal_IdAnimal",
                        column: x => x.IdAnimal,
                        principalTable: "TipoAnimal",
                        principalColumn: "IdTipoAnimal",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RegistroAtencionDb",
                columns: table => new
                {
                    IdRegistroAtencion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreRegistro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaRegistro = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DescripcionRegistro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdSolicitudAtencio = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroAtencionDb", x => x.IdRegistroAtencion);
                    table.ForeignKey(
                        name: "FK_RegistroAtencionDb_SolicitudAtencionDb_IdSolicitudAtencio",
                        column: x => x.IdSolicitudAtencio,
                        principalTable: "SolicitudAtencionDb",
                        principalColumn: "IdSolicitudAtencion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PropietarioDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPropietario = table.Column<int>(type: "int", nullable: false),
                    IdRegistroAtencion = table.Column<int>(type: "int", nullable: true),
                    IdMascota = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropietarioDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropietarioDb_MascotaDb_IdMascota",
                        column: x => x.IdMascota,
                        principalTable: "MascotaDb",
                        principalColumn: "IdMascota",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PropietarioDb_RegistroAtencionDb_IdRegistroAtencion",
                        column: x => x.IdRegistroAtencion,
                        principalTable: "RegistroAtencionDb",
                        principalColumn: "IdRegistroAtencion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MascotaDb_IdAnimal",
                table: "MascotaDb",
                column: "IdAnimal");

            migrationBuilder.CreateIndex(
                name: "IX_MedicosDb_IdAnimal",
                table: "MedicosDb",
                column: "IdAnimal");

            migrationBuilder.CreateIndex(
                name: "IX_MedicosDb_Nit",
                table: "MedicosDb",
                column: "Nit");

            migrationBuilder.CreateIndex(
                name: "IX_PropietarioDb_IdMascota",
                table: "PropietarioDb",
                column: "IdMascota");

            migrationBuilder.CreateIndex(
                name: "IX_PropietarioDb_IdRegistroAtencion",
                table: "PropietarioDb",
                column: "IdRegistroAtencion");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroAtencionDb_IdSolicitudAtencio",
                table: "RegistroAtencionDb",
                column: "IdSolicitudAtencio");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudAtencionDb_IdAnimal",
                table: "SolicitudAtencionDb",
                column: "IdAnimal");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudAtencionDb_IdMascota",
                table: "SolicitudAtencionDb",
                column: "IdMascota");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicosDb");

            migrationBuilder.DropTable(
                name: "PropietarioDb");

            migrationBuilder.DropTable(
                name: "EmpresaDb");

            migrationBuilder.DropTable(
                name: "RegistroAtencionDb");

            migrationBuilder.DropTable(
                name: "SolicitudAtencionDb");

            migrationBuilder.DropTable(
                name: "MascotaDb");

            migrationBuilder.DropTable(
                name: "TipoAnimal");
        }
    }
}
