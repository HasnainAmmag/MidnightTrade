using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Models
{
    public class NftCollection : CommonProperties
    {
        public string? Name { get; set; }
        public string? Url { get; set; }
        public string? Description { get; set; }
        public string? WebsiteLink { get; set; }
        //public string? DiscordLink { get; set; }
        //public string? TwitterLink { get; set; }
        //public string? InstagramLink { get; set; }
        //public string? MediumLink { get; set; }
        //public string? TLink { get; set; }
        public decimal? PercentageFee { get; set; }
        public long? CategoryId { get; set; }
        public long? BlockchainId { get; set; }
        public long? CurrencyId { get; set; }
        public long? AccountId { get; set; }
        public bool? SensitveContent { get; set; }
        public string? logoImage { get; set; }
        public string? FeaturedImage { get; set; }
        public bool IsAdminNftCollection { get; set; }
        public bool IsVerifiedCollection { get; set; }
        public string? BannerImage { get; set; }
        public virtual CollectionCategory? CollectionCategories { get; set; }
        //public virtual BlockChain BlockChain { get; set; }
        //public virtual Currency Currency { get; set; }
        //public virtual Account Account { get; set; }
        //public virtual ICollection<Nft> Nfts { get; set; }
    }
}
