using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IAccountRepository
    {
        Task<Account> GetByAddress(string address);
        Task<Account> UpdateAccount(Account Account);
        Task<Account> AddAccount(Account Account);
    }
}
