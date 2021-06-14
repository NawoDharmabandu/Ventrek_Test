using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NebulaToDo.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "STATUS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    STATUS_ID = table.Column<int>(type: "int", nullable: false),
                    STATUS_NAME = table.Column<string>(type: "nvarchar(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STATUS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TASK_DETAIL",
                columns: table => new
                {
                    TASK_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TASK_NAME = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    DUE_DATE = table.Column<DateTime>(type: "datetime", nullable: false),
                    TASK_STATUS = table.Column<int>(type: "int", nullable: false),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    CREATED_BY = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: false),
                    MODIFIED_BY = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    MODIFIED_DATE = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TASK_DETAIL", x => x.TASK_ID);
                });

            migrationBuilder.CreateTable(
                name: "USER",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USER_ID = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    USER_PASSWORD = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    USER_TITLE = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    USER_FNAME = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    USER_LNAME = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    USER_CONTACT = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    USER_EMAIL = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    USER_STATUS = table.Column<int>(type: "int", nullable: false),
                    CREATED_BY = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: false),
                    MODERATED_BY = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    MODERATED_DATE = table.Column<DateTime>(type: "datetime", nullable: false),
                    DEACTIVATED_BY = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    DEATIVATED_DATE = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "STATUS");

            migrationBuilder.DropTable(
                name: "TASK_DETAIL");

            migrationBuilder.DropTable(
                name: "USER");
        }
    }
}
