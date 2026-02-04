using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthServiceIN6BV.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class PendingChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "email_verfication_token_expity",
                table: "user_emails",
                newName: "email_verification_token_expiry");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "email_verification_token_expiry",
                table: "user_emails",
                newName: "email_verfication_token_expity");
        }
    }
}
