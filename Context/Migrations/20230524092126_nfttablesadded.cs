using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Context.Migrations
{
    /// <inheritdoc />
    public partial class nfttablesadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CollectionCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAdminNftCollectionCategories = table.Column<bool>(type: "bit", nullable: false),
                    Uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectionCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NftCollections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebsiteLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscordLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwitterLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstagramLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MediumLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PercentageFee = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CategoryId = table.Column<long>(type: "bigint", nullable: true),
                    BlockchainId = table.Column<long>(type: "bigint", nullable: true),
                    CurrencyId = table.Column<long>(type: "bigint", nullable: true),
                    AccountId = table.Column<long>(type: "bigint", nullable: true),
                    SensitveContent = table.Column<bool>(type: "bit", nullable: true),
                    logoImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeaturedImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAdminNftCollection = table.Column<bool>(type: "bit", nullable: false),
                    IsVerifiedCollection = table.Column<bool>(type: "bit", nullable: false),
                    BannerImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollectionCategoriesId = table.Column<int>(type: "int", nullable: true),
                    Uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NftCollections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NftCollections_CollectionCategories_CollectionCategoriesId",
                        column: x => x.CollectionCategoriesId,
                        principalTable: "CollectionCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Nfts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NFTTokenId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NFTContractAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NFTFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Staus = table.Column<int>(type: "int", nullable: false),
                    IsVerifiedNft = table.Column<bool>(type: "bit", nullable: false),
                    CollectionId = table.Column<long>(type: "bigint", nullable: true),
                    OwnerAccountId = table.Column<long>(type: "bigint", nullable: true),
                    CreatorAccountId = table.Column<long>(type: "bigint", nullable: true),
                    NftTransactionType = table.Column<int>(type: "int", nullable: false),
                    CurrentNftTransactionId = table.Column<long>(type: "bigint", nullable: true),
                    IsImport = table.Column<bool>(type: "bit", nullable: true),
                    IsSync = table.Column<bool>(type: "bit", nullable: false),
                    NftV2 = table.Column<bool>(type: "bit", nullable: false),
                    IsBurn = table.Column<bool>(type: "bit", nullable: false),
                    IsMinted = table.Column<bool>(type: "bit", nullable: true),
                    IsBidOpen = table.Column<bool>(type: "bit", nullable: true),
                    NftStandard = table.Column<int>(type: "int", nullable: false),
                    BidInitialMaximumAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BidInitialMinimumAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Royalty = table.Column<int>(type: "int", nullable: false),
                    BidStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BidEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ViewCount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsAdminNft = table.Column<bool>(type: "bit", nullable: false),
                    IsPhysicalNft = table.Column<bool>(type: "bit", nullable: false),
                    Processing = table.Column<int>(type: "int", nullable: true),
                    NftCollectionId = table.Column<int>(type: "int", nullable: true),
                    Uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nfts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nfts_NftCollections_NftCollectionId",
                        column: x => x.NftCollectionId,
                        principalTable: "NftCollections",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_NftCollections_CollectionCategoriesId",
                table: "NftCollections",
                column: "CollectionCategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Nfts_NftCollectionId",
                table: "Nfts",
                column: "NftCollectionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nfts");

            migrationBuilder.DropTable(
                name: "NftCollections");

            migrationBuilder.DropTable(
                name: "CollectionCategories");
        }
    }
}
