using Context;
using Microsoft.EntityFrameworkCore;
using Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementations
{
    public class AccountRepository : IAccountRepository
    {
        private readonly midnightDB _db;

        public AccountRepository(midnightDB db)
        {
            _db = db;
        }

        public async Task<Account> AddAccount(Account account)
        {
            await _db.Accounts.AddAsync(account);
            await _db.SaveChangesAsync();
            return account;
        }

        public async Task<Account> GetByAddress(string address)
        {
            return await _db.Accounts.Where(x => x.MetaMaskAddress == address && x.IsDeleted == false).FirstOrDefaultAsync();
        }
        public async Task<Account> UpdateAccount(Account account)
        {
            _db.Accounts.Update(account);
            await _db.SaveChangesAsync();
            return account;
        }

    }
}
