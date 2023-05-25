using Models;
using Nethereum.Util;
using Nethereum.Web3;
using Repository.Interfaces.Unit;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Services.Implementation
{
    public class AccountService : IAccountService
    {
        private readonly IRepositoryUnit _repository;


        public AccountService(IRepositoryUnit repository)
        {
            _repository = repository;
        }

        public async Task<Account> AddAccount(Account account)
        {
            await _repository.Account.AddAccount(account);
            return account;
        }

        public async Task<string> ConnectMetaMask(string walletAddress)
        {
            //try
            //{
                var checkAccount = await _repository.Account.GetByAddress(walletAddress);
                var randomString = Guid.NewGuid().ToString();
                if (checkAccount != null)
                {
                    checkAccount.TokenString = randomString;
                    await _repository.Account.UpdateAccount(checkAccount);
                }
                else
                {
                    Account account = new Account();
                    account.TokenString = randomString;
                    account.MetaMaskAddress = walletAddress;
                    await _repository.Account.AddAccount(account);
                }
                return randomString;
            //}
            //catch (Exception)
            //{
            //    return "An error occurred while connecting MetaMask";
            //}
        }
        public bool CheckAddress(string address)
        {
            try
            {
                if (address.Length != 42)
                    return false;

                var isHexString = Regex.IsMatch(address.Replace("0x", ""), @"\A\b[0-9a-fA-F]+\b\Z");
                if (!isHexString)
                    return false;

                if (!Web3.IsChecksumAddress(Web3.ToChecksumAddress(address)))
                    return false;

                var addressUtil = new AddressUtil();

                return addressUtil.IsValidEthereumAddressHexFormat(address);
            }
            catch (IndexOutOfRangeException)
            {
                // Web3.IsChecksumAddress convert hex string to byes to validate the address, if hex string is invalid then it will throw the IndexOutOfRangeException
                // but in our case it is still a invalid address
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
        }
    }
}
