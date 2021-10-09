using Microsoft.EntityFrameworkCore.Migrations;

namespace MascotaFeliz.app.persistencia.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonaDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropietarioDb",
                columns: table => new
                {
                    IdPropietario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropietarioDb", x => x.IdPropietario);
                });

            migrationBuilder.CreateTable(
                name: "SolicitudAtencion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMascota = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudAtencion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoAnimal",
                columns: table => new
                {
                    IdAnimal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAnimal", x => x.IdAnimal);
                });

            migrationBuilder.CreateTable(
                name: "MascotaDb",
                columns: table => new
                {
                    IdMascota = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ColorOjos = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ColorPiel = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Estatura = table.Column<int>(type: "int", nullable: false),
                    Peso = table.Column<int>(type: "int", nullable: false),
                    FrecuenciaCardiaca = table.Column<int>(type: "int", nullable: false),
                    FrecuenciaRespiratoria = table.Column<int>(type: "int", nullable: false),
                    IdPropietario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MascotaDb", x => x.IdMascota);
                    table.ForeignKey(
                        name: "FK_MascotaDb_PropietarioDb_IdPropietario",
                        column: x => x.IdPropietario,
                        principalTable: "PropietarioDb",
                        principalColumn: "IdPropietario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RegistroAtencionDb",
                columns: table => new
                {
                    IdAnimal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdPropietario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroAtencionDb", x => x.IdAnimal);
                    table.ForeignKey(
                        name: "FK_RegistroAtencionDb_PropietarioDb_IdPropietario",
                        column: x => x.IdPropietario,
                        principalTable: "PropietarioDb",
                        principalColumn: "IdPropietario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicosDb",
                columns: table => new
                {
                    IdMedico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TarjetaProfecional = table.Column<int>(type: "int", nullable: false),
                    Especialidad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IdAnimal = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicosDb", x => x.IdMedico);
                    table.ForeignKey(
                        name: "FK_MedicosDb_TipoAnimal_IdAnimal",
                        column: x => x.IdAnimal,
                        principalTable: "TipoAnimal",
                        principalColumn: "IdAnimal",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmpresaDb",
                columns: table => new
                {
                    Nit = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Direccion = table.Column<int>(type: "int", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    IdMedico = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaDb", x => x.Nit);
                    table.ForeignKey(
                        name: "FK_EmpresaDb_MedicosDb_IdMedico",
                        column: x => x.IdMedico,
                        principalTable: "MedicosDb",
                        principalColumn: "IdMedico",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaDb_IdMedico",
                table: "EmpresaDb",
                column: "IdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_MascotaDb_IdPropietario",
                table: "MascotaDb",
                column: "IdPropietario");

            migrationBuilder.CreateIndex(
                name: "IX_MedicosDb_IdAnimal",
                table: "MedicosDb",
                column: "IdAnimal");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroAtencionDb_IdPropietario",
                table: "RegistroAtencionDb",
                column: "IdPropietario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpresaDb");

            migrationBuilder.DropTable(
                name: "MascotaDb");

            migrationBuilder.DropTable(
                name: "PersonaDb");

            migrationBuilder.DropTable(
                name: "RegistroAtencionDb");

            migrationBuilder.DropTable(
                name: "SolicitudAtencion");

            migrationBuilder.DropTable(
                name: "MedicosDb");

            migrationBuilder.DropTable(
                name: "PropietarioDb");

            migrationBuilder.DropTable(
                name: "TipoAnimal");
        }
    }
}
