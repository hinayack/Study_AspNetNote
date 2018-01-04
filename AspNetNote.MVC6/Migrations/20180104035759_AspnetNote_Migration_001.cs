using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AspNetNote.MVC6.Migrations
{
    public partial class AspnetNote_Migration_001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_Num = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    User_Id = table.Column<string>(nullable: false),
                    User_Nmae = table.Column<string>(nullable: false),
                    User_Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_Num);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Note_Num = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Note_Contents = table.Column<string>(nullable: false),
                    Note_Title = table.Column<string>(nullable: false),
                    User_Num = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Note_Num);
                    table.ForeignKey(
                        name: "FK_Notes_Users_User_Num",
                        column: x => x.User_Num,
                        principalTable: "Users",
                        principalColumn: "User_Num",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notes_User_Num",
                table: "Notes",
                column: "User_Num");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
