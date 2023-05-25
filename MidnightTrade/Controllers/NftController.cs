using Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.RequestModels;
using Nethereum.BlockchainProcessing.BlockStorage.Entities;
using Nethereum.Web3;
using Newtonsoft.Json;
using Services.Interfaces.Unit;

namespace MidnightTrade.Controllers
{
  //  [Authorize]
    public class NftController : Controller
    {
        private readonly IServiceUnit _service;
        private readonly midnightDB _db;
        private readonly TokenController _tokenController;
        public NftController(IServiceUnit service, midnightDB db, TokenController tokenController)
        {
            _service = service;
            _db = db;
            _tokenController = tokenController;
        }
      //  [Route("CreateCategory")]
      //  [HttpPost]
      ////  [Authorize]

      //  public async Task<ActionResult> CreateCategory([FromForm] CategoryRequestModel request)
      //  {
      //      try
      //      {
      //          var result = await _service.Nft.CreateCategory(request);
      //          var resp = new
      //          {
      //              Status = true,
      //              Message = "Success",
      //              Data = result
      //          };
      //          return Ok(resp);
      //      }
      //      catch (Exception)
      //      {
      //          return StatusCode(500, "An error occurred while creating the category.");
      //      }
      //  }
        [Route("CreateCollection")]
        [HttpPost]
        public async Task<ActionResult> CreateCollection([FromForm] CollectionRequestModel request)
        {
            try
            {
                var find_category = await _db.CollectionCategories.FindAsync(request.CategoryId);
                if (find_category == null)
                {
                    var error = new
                    {
                        Status = false,
                        Message = "Category not found",
                        Data = ""
                    };
                    return Ok(error);
                }
             
                var result = await _service.Nft.CreateCollection(request);
                var resp = new
                {
                    Status = true,
                    Message = "Success",
                    Data = result
                };
                return Ok(resp);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while creating the Collection.");
            }
        }
        [Route("CreateNft")]
        [HttpPost]
        public async Task<ActionResult> CreateNft([FromForm] NftRequestModel request)
        {
            try
            {
                var find_collection = await _db.NftCollections.FindAsync(request.CollectionId);
                if (find_collection == null)
                {
                    var error = new
                    {
                        Status = false,
                        Message = "Collection not found",
                        Data = ""
                    };
                    return Ok(error);
                }
                if (request.NftProperties != null)
                {
                    request.NftProperties = JsonConvert.DeserializeObject<List<NftPropertyRequest>>(Request.Form["NftProperties"]);
                }

                var result = await _service.Nft.CreateNft(request);
                var resp = new
                {
                    Status = true,
                    Message = "Success",
                    Data = result
                };
                return Ok(resp);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while creating the Nft.");
            }
        }

        [Route("GetAllNfts")]
        [HttpGet]
        public async Task<ActionResult> GetAllNfts()
        {
            try
            {
                var result = await _service.Nft.GetAllNfts();
                var resp = new
                {
                    Status = true,
                    Message = "Success",
                    Data = result
                };
                return Ok(resp);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred.");
            }
        }

        [Route("GetAllCategories")]
        [HttpGet]
        public async Task<ActionResult> GetAllCategories()
        {
            try
            {
                var result = await _service.Nft.GetAllCategories();
                var resp = new
                {
                    Status = true,
                    Message = "Success",
                    Data = result
                };
                return Ok(resp);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred.");
            }
        }

        [Route("GetAllCollections")]
        [HttpGet]
        public async Task<ActionResult> GetAllCollections()
        {
            try
            {
                var result = await _service.Nft.GetAllCollections();
                var resp = new
                {
                    Status = true,
                    Message = "Success",
                    Data = result
                };
                return Ok(resp);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred.");
            }
        }

        [Route("VerifyTransactionHash")]
        [HttpGet]
        public async Task<ActionResult> VerifyTransactionHash(string rpcUrl, string transactionHash)
        {
            try
            {
                var web3 = new Web3(rpcUrl);
               // var web3 = new Web3("https://mainnet.infura.io/v3/097a0792735b4f35b16e667c5f5465bc");
               // var transactionHash = "0x1234567890abcdef1234567890abcdef1234567890abcdef1234567890abc123";
                var receipt = await web3.Eth.Transactions.GetTransactionReceipt.SendRequestAsync(transactionHash);
                dynamic resp;
                if (receipt != null && receipt.Status.Value == 1)
                {
                    resp = new
                    {
                        Status = true,
                        Message = "Success",
                    };
                }
                else
                {
                    resp = new
                    {
                        Status = true,
                        Message = "failed",
                    };
                }
                return Ok(resp);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred.");
            }
        }
        



    }
}
