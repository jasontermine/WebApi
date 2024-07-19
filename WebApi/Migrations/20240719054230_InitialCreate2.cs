using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "uuid",
                keyValue: new Guid("0c212166-0eea-4e3a-b1d9-3b116e0a505a"));

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "uuid",
                keyValue: new Guid("235bb79d-0342-406e-acf0-4b028bdf8c5e"));

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "uuid",
                keyValue: new Guid("a229202f-35a9-4592-a096-9df65f1e5ca2"));

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "uuid",
                keyValue: new Guid("f59dffff-6678-4b33-802b-615268c53a1e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "uuid",
                keyValue: new Guid("b6821df7-0c8d-47f8-aafe-4e20983a50e1"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "uuid",
                keyValue: new Guid("ba25013a-7c4a-46ca-8ea6-b025f5377f52"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "uuid",
                keyValue: new Guid("c62d8880-c8e0-476b-8fc1-1a59fffe7124"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "uuid",
                keyValue: new Guid("d6072945-4cb9-42fd-86de-b3b1e9059985"));

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "uuid", "Name", "dueDate", "startDate" },
                values: new object[,]
                {
                    { new Guid("049ac3bf-51c2-4143-b466-faa835a66817"), "Schanzenweg 8", new DateTime(2024, 12, 31, 23, 59, 59, 0, DateTimeKind.Utc), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("816474b0-ea46-4e44-a485-918f820f0df0"), "Rheinstrasse 3", new DateTime(2025, 2, 28, 23, 59, 59, 0, DateTimeKind.Utc), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("da2dc0cf-c3b2-49cc-a6ad-90ebf084c20f"), "Murtenstrasse 5", new DateTime(2024, 6, 30, 23, 59, 59, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fec3e824-27f2-4b86-98f2-de1ee44b6608"), "Könizstrasse 12", new DateTime(2024, 8, 31, 23, 59, 59, 0, DateTimeKind.Utc), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.UpdateData(
                table: "EmployeeAssignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignmentUuid", "EmployeeUuid" },
                values: new object[] { new Guid("da2dc0cf-c3b2-49cc-a6ad-90ebf084c20f"), new Guid("8031b974-8e11-43e4-8587-c419946c648f") });

            migrationBuilder.UpdateData(
                table: "EmployeeAssignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssignmentUuid", "EmployeeUuid" },
                values: new object[] { new Guid("049ac3bf-51c2-4143-b466-faa835a66817"), new Guid("7476f099-3f5c-4de2-90e2-e0fc1a94f4fe") });

            migrationBuilder.UpdateData(
                table: "EmployeeAssignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssignmentUuid", "EmployeeUuid" },
                values: new object[] { new Guid("fec3e824-27f2-4b86-98f2-de1ee44b6608"), new Guid("0fb4af0b-710b-43ca-94d3-41968ebd7136") });

            migrationBuilder.UpdateData(
                table: "EmployeeAssignments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssignmentUuid", "EmployeeUuid" },
                values: new object[] { new Guid("816474b0-ea46-4e44-a485-918f820f0df0"), new Guid("7c3c762e-f351-482d-b0c8-87027fa7c163") });

            migrationBuilder.UpdateData(
                table: "EmployeeAssignments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AssignmentUuid", "EmployeeUuid" },
                values: new object[] { new Guid("fec3e824-27f2-4b86-98f2-de1ee44b6608"), new Guid("8031b974-8e11-43e4-8587-c419946c648f") });

            migrationBuilder.UpdateData(
                table: "EmployeeAssignments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AssignmentUuid", "EmployeeUuid" },
                values: new object[] { new Guid("da2dc0cf-c3b2-49cc-a6ad-90ebf084c20f"), new Guid("0fb4af0b-710b-43ca-94d3-41968ebd7136") });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "uuid", "Age", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("0fb4af0b-710b-43ca-94d3-41968ebd7136"), 40, "Michael", "Smith" },
                    { new Guid("7476f099-3f5c-4de2-90e2-e0fc1a94f4fe"), 25, "Anna", "Karelia" },
                    { new Guid("7c3c762e-f351-482d-b0c8-87027fa7c163"), 35, "Emily", "Jones" },
                    { new Guid("8031b974-8e11-43e4-8587-c419946c648f"), 30, "John", "Doe" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "uuid",
                keyValue: new Guid("049ac3bf-51c2-4143-b466-faa835a66817"));

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "uuid",
                keyValue: new Guid("816474b0-ea46-4e44-a485-918f820f0df0"));

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "uuid",
                keyValue: new Guid("da2dc0cf-c3b2-49cc-a6ad-90ebf084c20f"));

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "uuid",
                keyValue: new Guid("fec3e824-27f2-4b86-98f2-de1ee44b6608"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "uuid",
                keyValue: new Guid("0fb4af0b-710b-43ca-94d3-41968ebd7136"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "uuid",
                keyValue: new Guid("7476f099-3f5c-4de2-90e2-e0fc1a94f4fe"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "uuid",
                keyValue: new Guid("7c3c762e-f351-482d-b0c8-87027fa7c163"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "uuid",
                keyValue: new Guid("8031b974-8e11-43e4-8587-c419946c648f"));

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

            migrationBuilder.UpdateData(
                table: "EmployeeAssignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignmentUuid", "EmployeeUuid" },
                values: new object[] { new Guid("0c212166-0eea-4e3a-b1d9-3b116e0a505a"), new Guid("b6821df7-0c8d-47f8-aafe-4e20983a50e1") });

            migrationBuilder.UpdateData(
                table: "EmployeeAssignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssignmentUuid", "EmployeeUuid" },
                values: new object[] { new Guid("235bb79d-0342-406e-acf0-4b028bdf8c5e"), new Guid("ba25013a-7c4a-46ca-8ea6-b025f5377f52") });

            migrationBuilder.UpdateData(
                table: "EmployeeAssignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssignmentUuid", "EmployeeUuid" },
                values: new object[] { new Guid("f59dffff-6678-4b33-802b-615268c53a1e"), new Guid("c62d8880-c8e0-476b-8fc1-1a59fffe7124") });

            migrationBuilder.UpdateData(
                table: "EmployeeAssignments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssignmentUuid", "EmployeeUuid" },
                values: new object[] { new Guid("a229202f-35a9-4592-a096-9df65f1e5ca2"), new Guid("d6072945-4cb9-42fd-86de-b3b1e9059985") });

            migrationBuilder.UpdateData(
                table: "EmployeeAssignments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AssignmentUuid", "EmployeeUuid" },
                values: new object[] { new Guid("f59dffff-6678-4b33-802b-615268c53a1e"), new Guid("b6821df7-0c8d-47f8-aafe-4e20983a50e1") });

            migrationBuilder.UpdateData(
                table: "EmployeeAssignments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AssignmentUuid", "EmployeeUuid" },
                values: new object[] { new Guid("0c212166-0eea-4e3a-b1d9-3b116e0a505a"), new Guid("c62d8880-c8e0-476b-8fc1-1a59fffe7124") });

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
        }
    }
}
