using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wallet_Wizard.Migrations
{
    /// <inheritdoc />
    public partial class TypoinTransactionId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TransationId",
                table: "Transactions",
                newName: "TransactionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TransactionId",
                table: "Transactions",
                newName: "TransationId");
        }
    }
}
