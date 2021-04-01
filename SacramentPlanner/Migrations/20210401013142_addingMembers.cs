using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentPlanner.Migrations
{
    public partial class addingMembers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speaker");

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    MembersID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calling = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MembersID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.CreateTable(
                name: "Speaker",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingId = table.Column<int>(type: "int", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    subject = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speaker", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Speaker_Meeting_MeetingId",
                        column: x => x.MeetingId,
                        principalTable: "Meeting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Speaker_MeetingId",
                table: "Speaker",
                column: "MeetingId");
        }
    }
}
