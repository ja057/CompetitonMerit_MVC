using Microsoft.EntityFrameworkCore.Migrations;
using System.IO;

namespace CompetitonMerit_MVC.Migrations
{
    public partial class Identity : Migration
    {
        private object sqlFile;

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "School",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    School_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    School_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    School_Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    School_Webite = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student_participate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Student_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Student_age = table.Column<int>(type: "int", nullable: false),
                    Mobile_Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Student_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Father_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_participate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject_language = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meritlist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Student_participateId = table.Column<int>(type: "int", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    Marks = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meritlist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meritlist_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Meritlist_Student_participate_Student_participateId",
                        column: x => x.Student_participateId,
                        principalTable: "Student_participate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Meritlist_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Meritlist_SchoolId",
                table: "Meritlist",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Meritlist_Student_participateId",
                table: "Meritlist",
                column: "Student_participateId");

            migrationBuilder.CreateIndex(
                name: "IX_Meritlist_SubjectId",
                table: "Meritlist",
                column: "SubjectId");

            sqlFile = Path.Combine(".\\DatabaseScript", @"Data.sql");

            migrationBuilder.Sql(File.ReadAllText((string)sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meritlist");

            migrationBuilder.DropTable(
                name: "School");

            migrationBuilder.DropTable(
                name: "Student_participate");

            migrationBuilder.DropTable(
                name: "Subject");
        }
    }
}
