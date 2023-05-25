using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Models;
using RLCMarketPlace.DTO.Enums;

namespace Context
{
    public class midnightDB : DbContext
    {
        public midnightDB(DbContextOptions<midnightDB> options)
              : base(options)
        { }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<CollectionCategory> CollectionCategories { get; set; }
        public virtual DbSet<NftCollection> NftCollections{ get; set; }
        public virtual DbSet<Nft> Nfts{ get; set; }
        public virtual DbSet<NftProperty> NftProperties{ get; set; }
    }
}