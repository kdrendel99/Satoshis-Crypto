using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SatoshisCrypto.Migrations
{
    public partial class Fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EthComments_EthComments_EthCommentCommentId",
                table: "EthComments");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.RenameColumn(
                name: "EthCommentCommentId",
                table: "EthComments",
                newName: "EthCommentId1");

            migrationBuilder.RenameColumn(
                name: "CommentId",
                table: "EthComments",
                newName: "EthCommentId");

            migrationBuilder.RenameIndex(
                name: "IX_EthComments_EthCommentCommentId",
                table: "EthComments",
                newName: "IX_EthComments_EthCommentId1");

            migrationBuilder.CreateTable(
                name: "AdaComments",
                columns: table => new
                {
                    AdaCommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Body = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Created_Utc = table.Column<int>(type: "int", nullable: false),
                    id = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    AdaCommentId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdaComments", x => x.AdaCommentId);
                    table.ForeignKey(
                        name: "FK_AdaComments_AdaComments_AdaCommentId1",
                        column: x => x.AdaCommentId1,
                        principalTable: "AdaComments",
                        principalColumn: "AdaCommentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BtcComments",
                columns: table => new
                {
                    BtcCommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Body = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Created_Utc = table.Column<int>(type: "int", nullable: false),
                    id = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    BtcCommentId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BtcComments", x => x.BtcCommentId);
                    table.ForeignKey(
                        name: "FK_BtcComments_BtcComments_BtcCommentId1",
                        column: x => x.BtcCommentId1,
                        principalTable: "BtcComments",
                        principalColumn: "BtcCommentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdaComments_AdaCommentId1",
                table: "AdaComments",
                column: "AdaCommentId1");

            migrationBuilder.CreateIndex(
                name: "IX_BtcComments_BtcCommentId1",
                table: "BtcComments",
                column: "BtcCommentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_EthComments_EthComments_EthCommentId1",
                table: "EthComments",
                column: "EthCommentId1",
                principalTable: "EthComments",
                principalColumn: "EthCommentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EthComments_EthComments_EthCommentId1",
                table: "EthComments");

            migrationBuilder.DropTable(
                name: "AdaComments");

            migrationBuilder.DropTable(
                name: "BtcComments");

            migrationBuilder.RenameColumn(
                name: "EthCommentId1",
                table: "EthComments",
                newName: "EthCommentCommentId");

            migrationBuilder.RenameColumn(
                name: "EthCommentId",
                table: "EthComments",
                newName: "CommentId");

            migrationBuilder.RenameIndex(
                name: "IX_EthComments_EthCommentId1",
                table: "EthComments",
                newName: "IX_EthComments_EthCommentCommentId");

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Body = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CommentId1 = table.Column<int>(type: "int", nullable: true),
                    Created_Utc = table.Column<int>(type: "int", nullable: false),
                    id = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Comments_CommentId1",
                        column: x => x.CommentId1,
                        principalTable: "Comments",
                        principalColumn: "CommentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CommentId1",
                table: "Comments",
                column: "CommentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_EthComments_EthComments_EthCommentCommentId",
                table: "EthComments",
                column: "EthCommentCommentId",
                principalTable: "EthComments",
                principalColumn: "CommentId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
