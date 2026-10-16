using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CincyGuard.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Crimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reportnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reportdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    reportstatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    starscategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    starscategorytype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    policedistrct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eventdate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lat_x = table.Column<double>(type: "float", nullable: true),
                    lon_x = table.Column<double>(type: "float", nullable: true),
                    snaneighborhood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    addressx = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crimes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Crimes");
        }
    }
}
