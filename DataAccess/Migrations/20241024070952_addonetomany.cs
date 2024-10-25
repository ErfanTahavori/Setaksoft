using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addonetomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "JobApplications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 1,
                column: "TagId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_JobApplications_TagId",
                table: "JobApplications",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplications_Tags_TagId",
                table: "JobApplications",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobApplications_Tags_TagId",
                table: "JobApplications");

            migrationBuilder.DropIndex(
                name: "IX_JobApplications_TagId",
                table: "JobApplications");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "JobApplications");

            migrationBuilder.CreateTable(
                name: "JobApplicationTags",
                columns: table => new
                {
                    JobApplicationsId = table.Column<int>(type: "int", nullable: false),
                    TagsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobApplicationTags", x => new { x.JobApplicationsId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_JobApplicationTags_JobApplications_JobApplicationsId",
                        column: x => x.JobApplicationsId,
                        principalTable: "JobApplications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobApplicationTags_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "JobApplicationTags",
                columns: new[] { "JobApplicationsId", "TagsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobApplicationTags_TagsId",
                table: "JobApplicationTags",
                column: "TagsId");
        }
    }
}
