using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SatoshisCrypto.Migrations
{
    public partial class ethereum_table_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EthComments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Body = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Created_Utc = table.Column<int>(type: "int", nullable: false),
                    id = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    EthCommentCommentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EthComments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_EthComments_EthComments_EthCommentCommentId",
                        column: x => x.EthCommentCommentId,
                        principalTable: "EthComments",
                        principalColumn: "CommentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EthComments_EthCommentCommentId",
                table: "EthComments",
                column: "EthCommentCommentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EthComments");
        }
    }
}
