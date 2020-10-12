using Microsoft.EntityFrameworkCore.Migrations;

namespace Quizz.DataAccess.Migrations
{
    public partial class QuizzDbv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exam",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    exam_name = table.Column<string>(maxLength: 50, nullable: true),
                    exam_status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    exam_id = table.Column<int>(nullable: false),
                    question_name = table.Column<string>(maxLength: 50, nullable: true),
                    Examid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.id);
                    table.ForeignKey(
                        name: "FK_Question_Exam_Examid",
                        column: x => x.Examid,
                        principalTable: "Exam",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    question_id = table.Column<int>(nullable: false),
                    answer_name = table.Column<string>(maxLength: 50, nullable: true),
                    answer_title = table.Column<string>(maxLength: 2, nullable: true),
                    Questionid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.id);
                    table.ForeignKey(
                        name: "FK_Answers_Question_Questionid",
                        column: x => x.Questionid,
                        principalTable: "Question",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_Questionid",
                table: "Answers",
                column: "Questionid");

            migrationBuilder.CreateIndex(
                name: "IX_Question_Examid",
                table: "Question",
                column: "Examid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Exam");
        }
    }
}
