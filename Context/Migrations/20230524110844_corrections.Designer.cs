﻿// <auto-generated />
using System;
using Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Context.Migrations
{
    [DbContext(typeof(midnightDB))]
    [Migration("20230524110844_corrections")]
    partial class corrections
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountStatus")
                        .HasColumnType("int");

                    b.Property<int>("AccountType")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminAccountId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BannerImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("MetaMaskAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TokenString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Models.CollectionCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAdminNftCollectionCategories")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("CollectionCategories");
                });

            modelBuilder.Entity("Models.Nft", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("BidEndDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("BidInitialMaximumAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("BidInitialMinimumAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("BidStartDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("CollectionId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long?>("CreatorAccountId")
                        .HasColumnType("bigint");

                    b.Property<long?>("CurrentNftTransactionId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdminNft")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsBidOpen")
                        .HasColumnType("bit");

                    b.Property<bool>("IsBurn")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsImport")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsMinted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPhysicalNft")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSync")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVerifiedNft")
                        .HasColumnType("bit");

                    b.Property<string>("NFTContractAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NFTFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NFTTokenId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NftCollectionId")
                        .HasColumnType("int");

                    b.Property<int>("NftStandard")
                        .HasColumnType("int");

                    b.Property<int>("NftTransactionType")
                        .HasColumnType("int");

                    b.Property<bool>("NftV2")
                        .HasColumnType("bit");

                    b.Property<long?>("OwnerAccountId")
                        .HasColumnType("bigint");

                    b.Property<int?>("Processing")
                        .HasColumnType("int");

                    b.Property<int>("Royalty")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("ViewCount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("NftCollectionId");

                    b.ToTable("Nfts");
                });

            modelBuilder.Entity("Models.NftCollection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<long?>("AccountId")
                        .HasColumnType("bigint");

                    b.Property<string>("BannerImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("BlockchainId")
                        .HasColumnType("bigint");

                    b.Property<long?>("CategoryId")
                        .HasColumnType("bigint");

                    b.Property<int?>("CollectionCategoriesId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long?>("CurrencyId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeaturedImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdminNftCollection")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVerifiedCollection")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("PercentageFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool?>("SensitveContent")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WebsiteLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("logoImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CollectionCategoriesId");

                    b.ToTable("NftCollections");
                });

            modelBuilder.Entity("Models.Nft", b =>
                {
                    b.HasOne("Models.NftCollection", "NftCollection")
                        .WithMany()
                        .HasForeignKey("NftCollectionId");

                    b.Navigation("NftCollection");
                });

            modelBuilder.Entity("Models.NftCollection", b =>
                {
                    b.HasOne("Models.CollectionCategory", "CollectionCategories")
                        .WithMany("NftCollection")
                        .HasForeignKey("CollectionCategoriesId");

                    b.Navigation("CollectionCategories");
                });

            modelBuilder.Entity("Models.CollectionCategory", b =>
                {
                    b.Navigation("NftCollection");
                });
#pragma warning restore 612, 618
        }
    }
}
