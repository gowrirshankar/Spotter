using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_spotter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    Model = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    Registration = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false),
                    Location = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2(0)", maxLength: 128, precision: 0, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_spotter", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "tbl_spotter",
                columns: new[] { "Id", "Date", "Location", "Make", "Model", "Registration" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 9, 23, 10, 30, 0, 0, DateTimeKind.Unspecified), "London Gatwick", "Boeing", "777-300ER", "G-RNAC" },
                    { 2, new DateTime(2020, 1, 6, 10, 30, 0, 0, DateTimeKind.Unspecified), "Leiden", "Airbus", "ACJ318", "AC-JET" },
                    { 3, new DateTime(2018, 12, 5, 10, 30, 0, 0, DateTimeKind.Unspecified), "Valcourt", "Bombardier", "Learjet70", "BO-LEA" },
                    { 4, new DateTime(2017, 5, 13, 10, 30, 0, 0, DateTimeKind.Unspecified), "China", "Cessna", "Sovereign", "CA-SOV" },
                    { 5, new DateTime(2018, 11, 6, 3, 40, 0, 0, DateTimeKind.Unspecified), "Southwest France", "Dassault", "Falcon900", "DF-TRI" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_spotter");
        }
    }
}
