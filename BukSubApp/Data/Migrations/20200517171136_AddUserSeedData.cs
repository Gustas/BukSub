using Microsoft.EntityFrameworkCore.Migrations;

namespace BukSub.Data.Migrations
{
    public partial class AddUserSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dc2e0be1-a196-4e43-a94e-d8b676a8834d", 0, "e20deb00-3fd4-4ae9-af11-aad58fb09785", "demo@example.com", true, true, null, "DEMO@EXAMPLE.COM", "DEMO@EXAMPLE.COM", "AQAAAAEAACcQAAAAELVllSq8QkfQEp5Gjf1Oc8SKQkpboufSkiWOBZpCYaVW45wjgew8/+KIqETk5SVVnQ==", null, false, "FZKI2CWMRGFQM4XKVCHRJDVENTMTAXBM", false, "demo@example.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc2e0be1-a196-4e43-a94e-d8b676a8834d");
        }
    }
}
