using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Models
{
    public  class CollectionCategory : CommonProperties
    {
        public string? Name { get; set; }

        public string? CategoryImage { get; set; }
        public virtual ICollection<NftCollection>? NftCollection { get; set; }
        public bool IsAdminNftCollectionCategories { get; set; }
    }
}
