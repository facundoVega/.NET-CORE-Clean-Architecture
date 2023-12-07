using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.LeaveManagement.Identity.Migrations
{
    /// <inheritdoc />
    public partial class ThirdIdentityMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b13fc86-cd45-4b9d-ba93-05b0602261f9", "AQAAAAIAAYagAAAAEEALlVvPBszPxVLjK9ZNsyH3ASO8OpRMYlsbnCp9KKYNDlSy0dYAVtPo/Jxtc+kI3g==", "88cac61e-d96b-4f1c-8721-ca063e3baf35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0724696-8ede-4d23-b2c4-b41d5d835529", "AQAAAAIAAYagAAAAEHuS4ii3LNLTi/4bi8jFWKE8GUvEvwmrqLBoO3KBOS0KhIDSHyiWZMJ6PgXso6mUQg==", "b93c9a76-2bdb-4350-96ce-3773fb79cec8" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dfe36ea-1d3c-41e3-b39b-727754526c2d", "AQAAAAIAAYagAAAAEOkkbufykjhaIY+1Ux/DrhtF6/etfYaE5fxC5spZbWhnJHVxiYLdUFhFu1Sd6aPNIA==", "5e346250-892f-4718-a7fb-d37e23dad66a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c7e3412-095a-4fb6-b229-878d3dced888", "AQAAAAIAAYagAAAAEFpQdxqc0249lvLrMY9YwBu2oguaoNRdy8E1FKDlM5CTPV7qDFoqWCc25sxv0lduEA==", "9101d67a-c061-45b9-b22f-d4e52845ea3c" });
        }
    }
}
