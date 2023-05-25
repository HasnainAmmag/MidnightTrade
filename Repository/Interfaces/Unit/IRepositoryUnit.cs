using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces.Unit
{
    public interface IRepositoryUnit
    {
      
        IAccountRepository Account { get; }
        INftRepository Nft { get; }

        void DetachAllEntities();

        void Save();

        Task SaveAsync();

        void BeginTransaction();

        void CommitTransaction();

        void RollBackTransaction();

        Task BeginTransactionAsync();
    }
}
