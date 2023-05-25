using Context;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.RequestModels;
using Repository.Interfaces;
using System.Threading.Tasks;

namespace Repository.Implementations
{
    public class NftRepository : INftRepository
    {
        private readonly midnightDB _db;

        public NftRepository(midnightDB db)
        {
            _db = db;
        }

       
        public async Task<CollectionCategory> CreateCategory(CollectionCategory category)
        {
            await _db.CollectionCategories.AddAsync(category);
            await _db.SaveChangesAsync();
            return category;
        }

        public async Task<NftCollection> CreateCollection(NftCollection collection)
        {
            await _db.NftCollections.AddAsync(collection);
            await _db.SaveChangesAsync();
            return collection;
        }

        public async Task<Nft> CreateNft(Nft nft)
        {
            await _db.Nfts.AddAsync(nft);
            await _db.SaveChangesAsync();
            return nft;
        }

        public async Task<ICollection<CollectionCategory>> GetAllCategories()
        {
            return await _db.CollectionCategories.Where(s => !s.IsDeleted).ToListAsync();
        }

        public async Task<ICollection<NftCollection>> GetAllCollections()
        {
            return await _db.NftCollections.Where(s => !s.IsDeleted).ToListAsync();
        }

        public async Task<ICollection<Nft>> GetAllNfts()
        {
            return await _db.Nfts.Where(s => !s.IsDeleted).ToListAsync();
        }

        public async Task<NftProperty> CreateNftProperty(NftProperty nftProperty)
        {
            _db.NftProperties.Add(nftProperty);
            var response = await _db.SaveChangesAsync();
            return nftProperty;
        }


    }
}
