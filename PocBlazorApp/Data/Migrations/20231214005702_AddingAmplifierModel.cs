using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PocBlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class AddingAmplifierModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AmplifierModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ohms = table.Column<double>(type: "float", nullable: true),
                    FrequencyResponse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LowPassFilter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighPassFilter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperatingVoltage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SignalToNoiseRatio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InputSensitivityRCA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InputSensitivityHighLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentDrawMusic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentDrawWithResistiveLoad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalEfficiency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DampingFactor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PowerCable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AudioOutputCable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecommendedFuse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecommendedBatteryMinimum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Width = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Length = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmplifierModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AmplifierModel_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AmplifierModel_ApplicationUserId",
                table: "AmplifierModel",
                column: "ApplicationUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmplifierModel");
        }
    }
}
