using Microsoft.EntityFrameworkCore;
using WebApi.Models;
using System;

namespace WebApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<EmployeeAssignment> EmployeeAssignments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var employee1Id = Guid.NewGuid();
            var employee2Id = Guid.NewGuid();
            var employee3Id = Guid.NewGuid();
            var employee4Id = Guid.NewGuid();

            var assignment1Id = Guid.NewGuid();
            var assignment2Id = Guid.NewGuid();
            var assignment3Id = Guid.NewGuid();
            var assignment4Id = Guid.NewGuid();

            modelBuilder.Entity<Employee>().HasData(
                new Employee { uuid = employee1Id, FirstName = "John", LastName = "Doe", Age = 30 },
                new Employee { uuid = employee2Id, FirstName = "Anna", LastName = "Karelia", Age = 25 },
                new Employee { uuid = employee3Id, FirstName = "Michael", LastName = "Smith", Age = 40 },
                new Employee { uuid = employee4Id, FirstName = "Emily", LastName = "Jones", Age = 35 }
            );

            modelBuilder.Entity<Assignment>().HasData(
                new Assignment
                {
                    uuid = assignment1Id,
                    Name = "Murtenstrasse 5",
                    startDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    dueDate = new DateTime(2024, 6, 30, 23, 59, 59, DateTimeKind.Utc)
                },
                new Assignment
                {
                    uuid = assignment2Id,
                    Name = "Schanzenweg 8",
                    startDate = new DateTime(2024, 7, 1, 0, 0, 0, DateTimeKind.Utc),
                    dueDate = new DateTime(2024, 12, 31, 23, 59, 59, DateTimeKind.Utc)
                },
                new Assignment
                {
                    uuid = assignment3Id,
                    Name = "Könizstrasse 12",
                    startDate = new DateTime(2024, 3, 1, 0, 0, 0, DateTimeKind.Utc),
                    dueDate = new DateTime(2024, 8, 31, 23, 59, 59, DateTimeKind.Utc)
                },
                new Assignment
                {
                    uuid = assignment4Id,
                    Name = "Rheinstrasse 3",
                    startDate = new DateTime(2024, 9, 1, 0, 0, 0, DateTimeKind.Utc),
                    dueDate = new DateTime(2025, 2, 28, 23, 59, 59, DateTimeKind.Utc)
                }
            );

            modelBuilder.Entity<EmployeeAssignment>().HasData(
                new EmployeeAssignment
                {
                    Id = 1,
                    EmployeeUuid = employee1Id,
                    AssignmentUuid = assignment1Id,
                    HoursWorked = 40
                },
                new EmployeeAssignment
                {
                    Id = 2,
                    EmployeeUuid = employee2Id,
                    AssignmentUuid = assignment2Id,
                    HoursWorked = 20
                },
                new EmployeeAssignment
                {
                    Id = 3,
                    EmployeeUuid = employee3Id,
                    AssignmentUuid = assignment3Id,
                    HoursWorked = 30
                },
                new EmployeeAssignment
                {
                    Id = 4,
                    EmployeeUuid = employee4Id,
                    AssignmentUuid = assignment4Id,
                    HoursWorked = 25
                },
                new EmployeeAssignment
                {
                    Id = 5,
                    EmployeeUuid = employee1Id,
                    AssignmentUuid = assignment3Id,
                    HoursWorked = 15
                },
                new EmployeeAssignment
                {
                    Id = 6,
                    EmployeeUuid = employee3Id,
                    AssignmentUuid = assignment1Id,
                    HoursWorked = 35
                }
            );
        }
    }
}
