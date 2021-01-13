using Microsoft.EntityFrameworkCore.Migrations;

namespace LiteChatWebsite.Migrations
{
    public partial class db_LiteChat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "t_roles",
                columns: table => new
                {
                    role_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    role_type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_roles", x => x.role_id);
                });

            migrationBuilder.CreateTable(
                name: "t_users",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    user_password = table.Column<string>(type: "char(72)", nullable: false),
                    role_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_users", x => x.user_id);
                    table.ForeignKey(
                        name: "FK_t_users_t_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "t_roles",
                        principalColumn: "role_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_t_users_role_id",
                table: "t_users",
                column: "role_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_users");

            migrationBuilder.DropTable(
                name: "t_roles");
        }
    }
}
