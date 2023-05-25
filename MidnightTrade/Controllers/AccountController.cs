using Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using Nethereum.Contracts.QueryHandlers.MultiCall;
using Nethereum.Contracts.Standards.ERC20.TokenList;
using Nethereum.Util;
using Nethereum.Web3;
using Services.Interfaces.Unit;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace MidnightTrade.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IServiceUnit _service;
        private readonly midnightDB _db;
        private readonly TokenController _tokenController;
        public AccountController(IServiceUnit service, midnightDB db, TokenController tokenController)
        {
            _service = service;
            _db = db;
            _tokenController = tokenController;
        }
        [Route("ConnectMetaMask")]
        [HttpPost]
        public async Task<ActionResult> ConnectMetaMask(string walletAddress)
        {
            try
            {
                var checkAddress = _service.Account.CheckAddress(walletAddress);
                if (checkAddress == false)
                {
                    var response = new
                    {
                        Status = false,
                        Message = "Invalid contract address.",
                        Data = ""
                    };
                    return Ok(response);
                }

                var result = await _service.Account.ConnectMetaMask(walletAddress);
                var resp = new
                {
                    Status = true,
                    Message = "Success",
                    Data = result
                };
                return Ok(resp);

            }
            catch (System.Exception)
            {
                throw;
            }
        }
        [Route("verifyConnectToken")]
        [HttpPost]
        public async Task<ActionResult<Account>> VerifyConnectToken(string walletAddress, string token)
        {
            try
            {
                var jwttoken = _tokenController.GenerateToken();
                var checkAddress = _service.Account.CheckAddress(walletAddress);
                if(checkAddress == false)
                {
                    var response = new
                    {
                        Status = false,
                        Message = "Invalid contract address.",
                        Data = ""
                    };
                    return Ok(response);
                }
                var find_account = await _db.Accounts
                    .Where(s => s.MetaMaskAddress == walletAddress && s.TokenString == token)
                    .FirstOrDefaultAsync();

                if (find_account != null)
                {
                    var response = new
                    {   
                        Status=true,
                        Message = "success",
                        Data = new
                        {
                            Token = jwttoken,
                            Result = find_account
                        }
                    };
                    return Ok(response);
                }
                var resp = new
                {
                    Status = false,
                    Message = "Token does not match.",
                    Data = ""
                };
                return Ok(resp);
              //  return Unauthorized("Token does not match");
            }
            catch (System.Exception)
            {
                throw;
            }
        }
      
    }
}
