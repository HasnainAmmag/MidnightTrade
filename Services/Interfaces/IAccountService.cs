using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Services.Interfaces
{
    public interface IAccountService
    {
        Task<string> ConnectMetaMask(string walletAddress);
        Task<Account> AddAccount(Account account);
        bool CheckAddress(string address);
    }
}
