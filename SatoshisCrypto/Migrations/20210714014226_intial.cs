using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SatoshisCrypto.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DogeComments",
                columns: table => new
                {
                    DogeCommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Body = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Created_Utc = table.Column<int>(type: "int", nullable: false),
                    id = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    DogeCommentId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogeComments", x => x.DogeCommentId);
                    table.ForeignKey(
                        name: "FK_DogeComments_DogeComments_DogeCommentId1",
                        column: x => x.DogeCommentId1,
                        principalTable: "DogeComments",
                        principalColumn: "DogeCommentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LinkComments",
                columns: table => new
                {
                    LinkCommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Body = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Created_Utc = table.Column<int>(type: "int", nullable: false),
                    id = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    LinkCommentId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkComments", x => x.LinkCommentId);
                    table.ForeignKey(
                        name: "FK_LinkComments_LinkComments_LinkCommentId1",
                        column: x => x.LinkCommentId1,
                        principalTable: "LinkComments",
                        principalColumn: "LinkCommentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DogeComments_DogeCommentId1",
                table: "DogeComments",
                column: "DogeCommentId1");

            migrationBuilder.CreateIndex(
                name: "IX_LinkComments_LinkCommentId1",
                table: "LinkComments",
                column: "LinkCommentId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DogeComments");

            migrationBuilder.DropTable(
                name: "LinkComments");
        }
    }
}
