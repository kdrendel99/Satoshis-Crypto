using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SatoshisCrypto.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "EthComments",
                columns: table => new
                {
                    EthCommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Body = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Created_Utc = table.Column<int>(type: "int", nullable: false),
                    id = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    EthCommentId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EthComments", x => x.EthCommentId);
                    table.ForeignKey(
                        name: "FK_EthComments_EthComments_EthCommentId1",
                        column: x => x.EthCommentId1,
                        principalTable: "EthComments",
                        principalColumn: "EthCommentId",
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
                name: "IX_AdaComments_AdaCommentId1",
                table: "AdaComments",
                column: "AdaCommentId1");

            migrationBuilder.CreateIndex(
                name: "IX_BtcComments_BtcCommentId1",
                table: "BtcComments",
                column: "BtcCommentId1");

            migrationBuilder.CreateIndex(
                name: "IX_DogeComments_DogeCommentId1",
                table: "DogeComments",
                column: "DogeCommentId1");

            migrationBuilder.CreateIndex(
                name: "IX_EthComments_EthCommentId1",
                table: "EthComments",
                column: "EthCommentId1");

            migrationBuilder.CreateIndex(
                name: "IX_LinkComments_LinkCommentId1",
                table: "LinkComments",
                column: "LinkCommentId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdaComments");

            migrationBuilder.DropTable(
                name: "BtcComments");

            migrationBuilder.DropTable(
                name: "DogeComments");

            migrationBuilder.DropTable(
                name: "EthComments");

            migrationBuilder.DropTable(
                name: "LinkComments");
        }
    }
}
