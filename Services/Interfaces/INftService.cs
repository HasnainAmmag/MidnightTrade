using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.RequestModels;

namespace Services.Interfaces
{
    public interface INftService
    {
        Task<CollectionCategory> CreateCategory(CategoryRequestModel request);
        Task<NftCollection> CreateCollection(CollectionRequestModel request);
        Task<Nft> CreateNft(NftRequestModel request);
        Task<ICollection<NftResponseModel>> GetAllNfts();
        Task<ICollection<CollectionResponseModel>> GetAllCollections();
        Task<ICollection<CategoryResponseModel>> GetAllCategories();
    }
}
