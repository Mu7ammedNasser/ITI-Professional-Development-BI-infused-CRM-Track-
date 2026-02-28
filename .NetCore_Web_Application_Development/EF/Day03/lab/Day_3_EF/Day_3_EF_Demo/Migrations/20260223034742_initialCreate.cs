using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Day_3_EF_Demo.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    DeptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.DeptId);
                });

            migrationBuilder.CreateTable(
                name: "emplyees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emplyees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_emplyees_departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "departments",
                        principalColumn: "DeptId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "departments",
                columns: new[] { "DeptId", "DeptName" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "HR" },
                    { 3, "Finance" }
                });

            migrationBuilder.InsertData(
                table: "emplyees",
                columns: new[] { "Id", "Age", "DepartmentId", "Email", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, 22, 2, "Alice@example.com", "Alice", 3000m },
                    { 2, 28, 1, "Bob@example.com", "Bob", 4500m },
                    { 3, 25, 3, "Charlie@example.com", "Charlie", 3500m },
                    { 4, 30, 1, "Diana@example.com", "Diana", 5000m },
                    { 5, 24, 2, "Eve@example.com", "Eve", 3200m },
                    { 6, 27, 3, "Frank@example.com", "Frank", 4000m },
                    { 7, 29, 1, "Grace@example.com", "Grace", 4800m },
                    { 8, 23, 2, "Henry@example.com", "Henry", 3300m },
                    { 9, 26, 3, "Iris@example.com", "Iris", 3800m },
                    { 10, 31, 1, "Jack@example.com", "Jack", 5200m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_emplyees_DepartmentId",
                table: "emplyees",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "emplyees");

            migrationBuilder.DropTable(
                name: "departments");
        }
    }
}
