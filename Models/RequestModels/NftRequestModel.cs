using Microsoft.AspNetCore.Http;
using Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Models.RequestModels
{
    public class NftRequestModel
    {
        //  public string? NFTTokenId { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? NFTContractAddress { get; set; }
        public string? Description { get; set; }
        public IFormFile Image { get; set; }

        //  public long? CurrencyId { get; set; }
        //public virtual Currency Currency { get; set; }
        //  public string? NFTFileName { get; set; }
        //public decimal BuyPrice { get; set; }
        //public decimal SellPrice { get; set; }
        public NftStatus Status { get; set; }
        // public NftOrignType OrignType { get; set; }
        //  public bool FreezeData { get; set; }
        //  public bool IsVerifiedNft { get; set; } = false;
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
        [Required]
        public int? CollectionId { get; set; }
        //public long? MintingAccountId { get; set; }
        public int? OwnerAccountId { get; set; }
        //public long? OldOwnerAccountId { get; set; }
        //  public long? CreatorAccountId { get; set; }
        //  public NftTransactionType NftTransactionType { get; set; }
        // public long? CurrentNftTransactionId { get; set; }
        //  public bool? IsImport { get; set; }
        //  public bool IsSync { get; set; }
        //  public bool NftV2 { get; set; } = false;
        //public bool IsBurn { get; set; }
        //public bool? IsMinted { get; set; }
        //public bool? IsBidOpen { get; set; }
        //public NftStandard NftStandard { get; set; } = NftStandard.ERC721;
        //public decimal? BidInitialMaximumAmount { get; set; }
        //public decimal? BidInitialMinimumAmount { get; set; }
        //public int Royalty { get; set; }
        //public DateTime? BidStartDate { get; set; }
        //public DateTime? BidEndDate { get; set; }
        //public decimal? ViewCount { get; set; }
        //public bool IsAdminNft { get; set; }
        //public bool IsPhysicalNft { get; set; }
        //public ENftProcess? Processing { get; set; }

        public virtual ICollection<NftPropertyRequest>? NftProperties { get; set; }


        ////   [ForeignKey("CollectionId")]
        //  public virtual NftCollection? NftCollection { get; set; }
    }

    public class NftPropertyRequest
    {
        public string? Name { get; set; }
        public string? Type { get; set; }
        //   public int Rarity { get; set; }
        //public int NftId { get; set; }
        //public virtual Nft? Nft { get; set; }
    }
}
