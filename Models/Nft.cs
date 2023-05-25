using Models.Enum;
using Models.Enums;
using RLCMarketPlace.DTO.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Nft : CommonProperties
    {
        public string? NFTTokenId { get; set; }
        public string? Name { get; set; }
        public string? NFTContractAddress { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
      
        //  public long? CurrencyId { get; set; }
        //public virtual Currency Currency { get; set; }
        public string? NFTFileName { get; set; }
        //public decimal BuyPrice { get; set; }
        //public decimal SellPrice { get; set; }
        public NftStatus Status { get; set; }
        // public NftOrignType OrignType { get; set; }
        //  public bool FreezeData { get; set; }
        public bool IsVerifiedNft { get; set; } = false;
        //public string? FreezeTransactionHash { get; set; }
        //public string? IPfsURL { get; set; }
        //public FreezeTransactionStauts? freezeTransactionStauts { get; set; }
        //public bool? UnlockableContent { get; set; }
        //public string? UnlockableContentNote { get; set; }
        //public bool? SensitiveContent { get; set; }
        //public decimal? Supply { get; set; }
        //public long? BlockChainId { get; set; }
        //public bool IsMakeOffer { get; set; } = false;
        //public virtual BlockChain BlockChain { get; set; }
        //public string BlockChainName { get; set; }
        public long? CollectionId { get; set; }
        //public long? MintingAccountId { get; set; }
        public long? OwnerAccountId { get; set; }
        //public long? OldOwnerAccountId { get; set; }
        public long? CreatorAccountId { get; set; }
        public NftTransactionType NftTransactionType { get; set; }
        public long? CurrentNftTransactionId { get; set; }
        public bool? IsImport { get; set; }
        public bool IsSync { get; set; }
        public bool NftV2 { get; set; } = false;
        public bool IsBurn { get; set; }
        public bool? IsMinted { get; set; }
        public bool? IsBidOpen { get; set; }
        public NftStandard NftStandard { get; set; } = NftStandard.ERC721;
        public decimal? BidInitialMaximumAmount { get; set; }
        public decimal? BidInitialMinimumAmount { get; set; }
        public int Royalty { get; set; }
        public DateTime? BidStartDate { get; set; }
        public DateTime? BidEndDate { get; set; }
        public decimal? ViewCount { get; set; }
        public bool IsAdminNft { get; set; }
        public bool IsPhysicalNft { get; set; }
        public ENftProcess? Processing { get; set; }

     //   [ForeignKey("CollectionId")]
        public virtual NftCollection? NftCollection { get; set; }    
        public virtual ICollection<NftProperty> NftProperties { get; set; }
        //public virtual ICollection<NftOrder> NftOrders { get; set; }
        //public virtual ICollection<NftLevels> NftLevels { get; set; }
        //public virtual ICollection<NftStats> NftStats { get; set; }
        //public virtual ICollection<NftHistory> NftHistory { get; set; }
        //public virtual ICollection<NftTransaction> NftTransactions { get; set; }
        //public virtual ICollection<FavouriteNfts> FavouriteNft { get; set; }
        //public virtual ICollection<NftBid> NftBids { get; set; }
        //public virtual ICollection<NftViewedHistory> NftViewedHistory { get; set; }
        //public virtual ICollection<NftRatings> NftRatings { get; set; }
        //public virtual Account MintingAccount { get; set; }
        //public virtual Account OwnerAccount { get; set; }
        //public virtual Account OldOwnerAccount { get; set; }
        //public virtual Account CreatorAccount { get; set; }
    }
}
