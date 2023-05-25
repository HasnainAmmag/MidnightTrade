using Microsoft.AspNetCore.Http;
using Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Models.RequestModels
{
    public class CollectionResponseModel
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string WebsiteLink { get; set; }
     
        public decimal? PercentageFee { get; set; }
        public long? CategoryId { get; set; }
        public long BlockchainId { get; set; }
        public long CurrencyId { get; set; }
        public long AccountId { get; set; }
        public bool SensitveContent { get; set; }
        public string logoImage { get; set; }
        public string FeaturedImage { get; set; }
        public bool IsAdminNftCollection { get; set; }
        public bool IsVerifiedCollection { get; set; }
        public string BannerImage { get; set; }
     //   public virtual CollectionCategory? CollectionCategories { get; set; }
    }
}
