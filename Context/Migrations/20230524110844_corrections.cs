using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Context.Migrations
{
    /// <inheritdoc />
    public partial class corrections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscordLink",
                table: "NftCollections");

            migrationBuilder.DropColumn(
                name: "InstagramLink",
                table: "NftCollections");

            migrationBuilder.DropColumn(
                name: "MediumLink",
                table: "NftCollections");

            migrationBuilder.DropColumn(
                name: "TLink",
                table: "NftCollections");

            migrationBuilder.DropColumn(
                name: "TwitterLink",
                table: "NftCollections");

            migrationBuilder.RenameColumn(
                name: "Staus",
                table: "Nfts",
                newName: "Status");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Nfts",
                newName: "Staus");

            migrationBuilder.AddColumn<string>(
                name: "DiscordLink",
                table: "NftCollections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InstagramLink",
                table: "NftCollections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MediumLink",
                table: "NftCollections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TLink",
                table: "NftCollections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TwitterLink",
                table: "NftCollections",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
