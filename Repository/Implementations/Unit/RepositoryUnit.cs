using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Context;
using Repository.Interfaces;
using Repository.Implementations;
using Repository.Interfaces.Unit;

namespace Repository.Implementations.Unit
{
    public class RepositoryUnit : IRepositoryUnit
    {
        private readonly midnightDB _db;

       
        private IAccountRepository _account;
        private INftRepository _nft;

        public RepositoryUnit(midnightDB db, IAccountRepository account, INftRepository nft)
        {
            _db = db;
            _account = account;
            _nft = nft;
        }


        public IAccountRepository Account =>
            _account ??= new AccountRepository(_db);
        public INftRepository Nft =>
           _nft ??= new NftRepository(_db);


        public void Save()
        {
            SetCommonValues();
            _db.SaveChanges();
        }

        public void SetCommonValues()
        {
            var AddedEntities = _db.ChangeTracker.Entries()
        .Where(E => E.State == EntityState.Added)
        .ToList();

            AddedEntities.ForEach(E =>
            {
                E.Property("CreatedAt").CurrentValue = E.Property("UpdatedAt").CurrentValue = DateTime.UtcNow;
            });

            var EditedEntities = _db.ChangeTracker.Entries()
                .Where(E => E.State == EntityState.Modified)
                .ToList();

            EditedEntities.ForEach(E =>
            {
                E.Property("UpdatedAt").CurrentValue = DateTime.UtcNow;
            });
        }

        public async Task SaveAsync()
        {
            SetCommonValues();
            await _db.SaveChangesAsync();
        }

        public void BeginTransaction()
        {
            _db.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _db.Database.CommitTransaction();
        }

        public void RollBackTransaction()
        {
            _db.Database.RollbackTransaction();
        }

        public async Task BeginTransactionAsync()
        {
            await _db.Database.BeginTransactionAsync();
        }

        public void DetachAllEntities()
        {
            var changedEntriesCopy = _db.ChangeTracker.Entries()
                .ToList();

            foreach (var entry in changedEntriesCopy)
                entry.State = EntityState.Detached;
        }
    }
}
