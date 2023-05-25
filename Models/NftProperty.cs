using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    public class NftProperty : CommonProperties
    {
        public string? Name { get; set; }
        public string? Type { get; set; }
     //   public int Rarity { get; set; }
        public int NftId { get; set; }
        //[JsonIgnore]
      //  public virtual Nft? Nft { get; set; }
    }
}
