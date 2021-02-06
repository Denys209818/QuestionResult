using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QuestionResult.DAL.Migrations
{
    public partial class addtablestblQuestiontblAnswertblResult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "tblUsers",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Login",
                table: "tblUsers",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "tblUsers",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "tblUsers",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldMaxLength: 255);

            migrationBuilder.CreateTable(
                name: "tblQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Text = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblQuestions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Text = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    IsTrue = table.Column<bool>(type: "boolean", nullable: false),
                    QuestionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblAnswers_tblQuestions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "tblQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AnswerId = table.Column<int>(type: "integer", nullable: false),
                    SessionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblResults_tblAnswers_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "tblAnswers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblResults_tblSessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "tblSessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblAnswers_QuestionId",
                table: "tblAnswers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_tblResults_AnswerId",
                table: "tblResults",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_tblResults_SessionId",
                table: "tblResults",
                column: "SessionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblResults");

            migrationBuilder.DropTable(
                name: "tblAnswers");

            migrationBuilder.DropTable(
                name: "tblQuestions");

            migrationBuilder.AlterColumn<int>(
                name: "Password",
                table: "tblUsers",
                type: "integer",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<int>(
                name: "Login",
                table: "tblUsers",
                type: "integer",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<int>(
                name: "LastName",
                table: "tblUsers",
                type: "integer",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<int>(
                name: "FirstName",
                table: "tblUsers",
                type: "integer",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);
        }
    }
}
