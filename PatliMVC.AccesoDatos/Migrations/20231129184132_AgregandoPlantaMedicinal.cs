using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatliMVC.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class AgregandoPlantaMedicinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlantasMedicinales",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreComun = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombreCientifico = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombreNahuatl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(2500)", maxLength: 2500, nullable: false),
                    UsoMedicinal = table.Column<string>(type: "nvarchar(2500)", maxLength: 2500, nullable: false),
                    Contraindicaciones = table.Column<string>(type: "nvarchar(2500)", maxLength: 2500, nullable: false),
                    EvaluacionCientifica = table.Column<string>(type: "nvarchar(2500)", maxLength: 2500, nullable: false),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aprobado = table.Column<bool>(type: "bit", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantasMedicinales", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlantasMedicinales");
        }
    }
}
