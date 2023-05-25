using Context.Migrations;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Hosting.Internal;
using Models;
using Models.Enums;
using Models.RequestModels;
using Repository.Interfaces.Unit;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementation
{
    internal class NftService : INftService
    {
        private readonly IRepositoryUnit _repository;
        private readonly IWebHostEnvironment _environment;
        public NftService(IRepositoryUnit repository, IWebHostEnvironment hostingEnvironment)
        {
            _repository = repository;
            _environment = hostingEnvironment;
        }


        public async Task<CollectionCategory> CreateCategory(CategoryRequestModel request)
        {
            CollectionCategory category = new CollectionCategory();

            if (request.CategoryImage != null)
                category.CategoryImage = await Image_uploading(request.CategoryImage, "Images\\Category");


            category.Name = request.Name;
            //category.CategoryImage = request.CategoryImage;
            await _repository.Nft.CreateCategory(category);

            return category;
        }

        public async Task<NftCollection> CreateCollection(CollectionRequestModel request)
        {
            NftCollection collection = new NftCollection();

            if (request.logoImage != null)
                collection.logoImage = await Image_uploading(request.logoImage, "Images\\Collection\\Logo");

            if (request.FeaturedImage != null)
                collection.FeaturedImage = await Image_uploading(request.FeaturedImage, "Images\\Collection\\Feature");

            if (request.BannerImage != null)
                collection.BannerImage = await Image_uploading(request.BannerImage, "Images\\Collection\\Banner");


            collection.Name = request.Name;
            collection.Description = request.Description;
            collection.WebsiteLink = request.WebsiteLink;
            collection.PercentageFee = request.PercentageFee;
            collection.CategoryId = request.CategoryId;
            await _repository.Nft.CreateCollection(collection);

            return collection;
        }

        public async Task<Nft> CreateNft(NftRequestModel request)
        {
            Nft nft = new Nft();

            if (request.Image != null)
                nft.Image = await Image_uploading(request.Image, "Images\\Nft");

            nft.Name = request.Name;
            nft.NFTContractAddress = request.NFTContractAddress;
            nft.Description = request.Description;
            nft.Status = request.Status;
            nft.CollectionId = request.CollectionId;
            nft.OwnerAccountId = request.OwnerAccountId;

            await _repository.Nft.CreateNft(nft);

            if (request.NftProperties != null)
            {
                foreach (var item in request.NftProperties)
                {
                    var nftProperty = new NftProperty();
                    nftProperty.NftId = nft.Id;
                    nftProperty.Name = item.Name;
                    nftProperty.Type = item.Type;

                    await _repository.Nft.CreateNftProperty(nftProperty);
                }
            }

            return nft;
        }


        public async Task<ICollection<NftResponseModel>> GetAllNfts()
        {
            var data = await _repository.Nft.GetAllNfts();

            var responseList = new List<NftResponseModel>();

            foreach (var item in data)
            {
                NftResponseModel response = new NftResponseModel();
                response.Name = item.Name;
                response.NFTContractAddress = item.NFTContractAddress;
                response.Description = item.Description;
                response.Status = item.Status;
                response.Image = item.Image;
                response.CollectionId = item.CollectionId;
                response.IsMinted = item.IsMinted;
             

                responseList.Add(response);
            }

            return responseList;
        }

        public async Task<ICollection<CollectionResponseModel>> GetAllCollections()
        {
            var data = await _repository.Nft.GetAllCollections();

            var responseList = new List<CollectionResponseModel>();

            foreach (var item in data)
            {
                CollectionResponseModel response = new CollectionResponseModel();
                response.Name = item.Name;
                response.Url = item.Url;
                response.Description = item.Description;
                response.WebsiteLink = item.WebsiteLink;
                response.PercentageFee = item.PercentageFee;
                response.CategoryId = item.CategoryId;
                response.logoImage = item.logoImage;
                response.FeaturedImage = item.FeaturedImage;
                response.IsAdminNftCollection = item.IsAdminNftCollection;
                response.IsVerifiedCollection = item.IsVerifiedCollection;
                response.BannerImage = item.BannerImage;


                responseList.Add(response);
            }

            return responseList;
        }
        public async Task<ICollection<CategoryResponseModel>> GetAllCategories()
         {
            var data = await _repository.Nft.GetAllCategories();
            var responseList = new List<CategoryResponseModel>();

            foreach (var item in data)
            {
                CategoryResponseModel response = new CategoryResponseModel();
                response.Name = item.Name;
                response.CategoryImage = item.CategoryImage;

                responseList.Add(response);
            }

            return responseList;
        }

public async Task<string> Image_uploading(IFormFile Image, string folder)
        {
            string wwwRootPath = _environment.ContentRootPath;
            string fileName = Path.GetFileNameWithoutExtension(Image.FileName);
            string extension = Path.GetExtension(Image.FileName);
            string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".gif" }; 

            // Validate the file extension
            if (!allowedExtensions.Contains(extension))
            {
                throw new ArgumentException("Invalid file extension.");
            }

            string newName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootPath + folder, newName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await Image.CopyToAsync(fileStream);
            }
            return path;
        }
    }
}
