using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    uuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    startDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dueDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.uuid);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    uuid = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.uuid);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeAssignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeUuid = table.Column<Guid>(type: "uuid", nullable: false),
                    AssignmentUuid = table.Column<Guid>(type: "uuid", nullable: false),
                    HoursWorked = table.Column<float>(type: "real", nullable: false),
                    RecordedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeAssignments_Assignments_AssignmentUuid",
                        column: x => x.AssignmentUuid,
                        principalTable: "Assignments",
                        principalColumn: "uuid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeAssignments_Employees_EmployeeUuid",
                        column: x => x.EmployeeUuid,
                        principalTable: "Employees",
                        principalColumn: "uuid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "uuid", "Name", "dueDate", "startDate" },
                values: new object[,]
                {
                    { new Guid("0c212166-0eea-4e3a-b1d9-3b116e0a505a"), "Project Alpha", new DateTime(2024, 6, 30, 23, 59, 59, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("235bb79d-0342-406e-acf0-4b028bdf8c5e"), "Project Beta", new DateTime(2024, 12, 31, 23, 59, 59, 0, DateTimeKind.Utc), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a229202f-35a9-4592-a096-9df65f1e5ca2"), "Project Delta", new DateTime(2025, 2, 28, 23, 59, 59, 0, DateTimeKind.Utc), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f59dffff-6678-4b33-802b-615268c53a1e"), "Project Gamma", new DateTime(2024, 8, 31, 23, 59, 59, 0, DateTimeKind.Utc), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "uuid", "Age", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("b6821df7-0c8d-47f8-aafe-4e20983a50e1"), 30, "John", "Doe" },
                    { new Guid("ba25013a-7c4a-46ca-8ea6-b025f5377f52"), 25, "Anna", "Karelia" },
                    { new Guid("c62d8880-c8e0-476b-8fc1-1a59fffe7124"), 40, "Michael", "Smith" },
                    { new Guid("d6072945-4cb9-42fd-86de-b3b1e9059985"), 35, "Emily", "Jones" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeAssignments",
                columns: new[] { "Id", "AssignmentUuid", "EmployeeUuid", "HoursWorked", "RecordedAt" },
                values: new object[,]
                {
                    { 1, new Guid("0c212166-0eea-4e3a-b1d9-3b116e0a505a"), new Guid("b6821df7-0c8d-47f8-aafe-4e20983a50e1"), 40f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new Guid("235bb79d-0342-406e-acf0-4b028bdf8c5e"), new Guid("ba25013a-7c4a-46ca-8ea6-b025f5377f52"), 20f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new Guid("f59dffff-6678-4b33-802b-615268c53a1e"), new Guid("c62d8880-c8e0-476b-8fc1-1a59fffe7124"), 30f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new Guid("a229202f-35a9-4592-a096-9df65f1e5ca2"), new Guid("d6072945-4cb9-42fd-86de-b3b1e9059985"), 25f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new Guid("f59dffff-6678-4b33-802b-615268c53a1e"), new Guid("b6821df7-0c8d-47f8-aafe-4e20983a50e1"), 15f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new Guid("0c212166-0eea-4e3a-b1d9-3b116e0a505a"), new Guid("c62d8880-c8e0-476b-8fc1-1a59fffe7124"), 35f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAssignments_AssignmentUuid",
                table: "EmployeeAssignments",
                column: "AssignmentUuid");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAssignments_EmployeeUuid",
                table: "EmployeeAssignments",
                column: "EmployeeUuid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeAssignments");

            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
