using Microsoft.EntityFrameworkCore.Migrations;

namespace MascotaFeliz.app.persistencia.Migrations
{
    public partial class Inicial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SolicitudAtencion",
                table: "SolicitudAtencion");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "EmpresaDb");

            migrationBuilder.RenameTable(
                name: "SolicitudAtencion",
                newName: "SolicitudAtencionDb");

            migrationBuilder.RenameColumn(
                name: "IdAnimal",
                table: "TipoAnimal",
                newName: "IdTipoAnimal");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "RegistroAtencionDb",
                newName: "NombreRegistro");

            migrationBuilder.RenameColumn(
                name: "IdAnimal",
                table: "RegistroAtencionDb",
                newName: "IdRegistroAtencion");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "PropietarioDb",
                newName: "NombrePropietario");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "PersonaDb",
                newName: "NombrePersona");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PersonaDb",
                newName: "IdPersona");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "MedicosDb",
                newName: "NombreMedico");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "MascotaDb",
                newName: "NombreMascota");

            migrationBuilder.RenameColumn(
                name: "Telefono",
                table: "EmpresaDb",
                newName: "TelefonoEmpresa");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "EmpresaDb",
                newName: "NombreEmpresa");

            migrationBuilder.RenameColumn(
                name: "NombreMascota",
                table: "SolicitudAtencionDb",
                newName: "NombreSolicitud");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SolicitudAtencionDb",
                newName: "IdSolicitudAtencion");

            migrationBuilder.AddColumn<string>(
                name: "DescripcionRegistro",
                table: "RegistroAtencionDb",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FechaRegistro",
                table: "RegistroAtencionDb",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "PersonaDb",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DireccionEmpresa",
                table: "EmpresaDb",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DetalleSolicitud",
                table: "SolicitudAtencionDb",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FechaSolicitud",
                table: "SolicitudAtencionDb",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SolicitudAtencionDb",
                table: "SolicitudAtencionDb",
                column: "IdSolicitudAtencion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SolicitudAtencionDb",
                table: "SolicitudAtencionDb");

            migrationBuilder.DropColumn(
                name: "DescripcionRegistro",
                table: "RegistroAtencionDb");

            migrationBuilder.DropColumn(
                name: "FechaRegistro",
                table: "RegistroAtencionDb");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "PersonaDb");

            migrationBuilder.DropColumn(
                name: "DireccionEmpresa",
                table: "EmpresaDb");

            migrationBuilder.DropColumn(
                name: "DetalleSolicitud",
                table: "SolicitudAtencionDb");

            migrationBuilder.DropColumn(
                name: "FechaSolicitud",
                table: "SolicitudAtencionDb");

            migrationBuilder.RenameTable(
                name: "SolicitudAtencionDb",
                newName: "SolicitudAtencion");

            migrationBuilder.RenameColumn(
                name: "IdTipoAnimal",
                table: "TipoAnimal",
                newName: "IdAnimal");

            migrationBuilder.RenameColumn(
                name: "NombreRegistro",
                table: "RegistroAtencionDb",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "IdRegistroAtencion",
                table: "RegistroAtencionDb",
                newName: "IdAnimal");

            migrationBuilder.RenameColumn(
                name: "NombrePropietario",
                table: "PropietarioDb",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "NombrePersona",
                table: "PersonaDb",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "IdPersona",
                table: "PersonaDb",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "NombreMedico",
                table: "MedicosDb",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "NombreMascota",
                table: "MascotaDb",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "TelefonoEmpresa",
                table: "EmpresaDb",
                newName: "Telefono");

            migrationBuilder.RenameColumn(
                name: "NombreEmpresa",
                table: "EmpresaDb",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "NombreSolicitud",
                table: "SolicitudAtencion",
                newName: "NombreMascota");

            migrationBuilder.RenameColumn(
                name: "IdSolicitudAtencion",
                table: "SolicitudAtencion",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "Direccion",
                table: "EmpresaDb",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SolicitudAtencion",
                table: "SolicitudAtencion",
                column: "Id");
        }
    }
}
