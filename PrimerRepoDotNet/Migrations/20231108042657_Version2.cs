using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimerRepoDotNet.Migrations
{
    public partial class Version2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_firstName = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    user_lastName = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    user_password = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    user_DNI = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    user_email = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    user_isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.user_id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "user_id", "user_DNI", "user_email", "user_firstName", "user_isDeleted", "user_lastName", "user_password" },
                values: new object[] { 1, "32158119", "etcheparede@gmail.com", "David", false, "Etchepare", "1234" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "user_id", "user_DNI", "user_email", "user_firstName", "user_isDeleted", "user_lastName", "user_password" },
                values: new object[] { 2, "32206717", "natalia@gmail.com", "Natalia", false, "Cajal", "1234" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
