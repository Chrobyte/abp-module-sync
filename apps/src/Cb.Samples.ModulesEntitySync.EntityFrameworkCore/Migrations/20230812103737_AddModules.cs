using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cb.Samples.ModulesEntitySync.Migrations
{
    /// <inheritdoc />
    public partial class AddModules : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerManagementCountries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerManagementCountries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectManagementCustomers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectManagementCustomers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerManagementCustomers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerManagementCustomers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerManagementCustomers_CustomerManagementCountries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "CustomerManagementCountries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectManagementProjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectManagementProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectManagementProjects_ProjectManagementCustomers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "ProjectManagementCustomers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerManagementCustomers_CountryId",
                table: "CustomerManagementCustomers",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectManagementProjects_CustomerId",
                table: "ProjectManagementProjects",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerManagementCustomers");

            migrationBuilder.DropTable(
                name: "ProjectManagementProjects");

            migrationBuilder.DropTable(
                name: "CustomerManagementCountries");

            migrationBuilder.DropTable(
                name: "ProjectManagementCustomers");
        }
    }
}
