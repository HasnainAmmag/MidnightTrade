using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface INftRepository
    {
        Task<CollectionCategory> CreateCategory(CollectionCategory category);
        Task<NftCollection> CreateCollection(NftCollection collection);
        Task<Nft> CreateNft(Nft nft);
        Task<ICollection<Nft>> GetAllNfts();
        Task<ICollection<NftCollection>> GetAllCollections();
        Task<ICollection<CollectionCategory>> GetAllCategories();

        Task<NftProperty> CreateNftProperty(NftProperty nftProperty);
    }
}
