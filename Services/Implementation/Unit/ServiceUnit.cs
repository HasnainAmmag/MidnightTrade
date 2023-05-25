using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Interfaces;
using Services.Implementation;
using Services.Interfaces.Unit;
using Repository.Interfaces.Unit;

namespace Service.Implementations.Unit
{
    internal class ServiceUnit : IServiceUnit
    {

        private readonly IRepositoryUnit _repository;
        private readonly IWebHostEnvironment _hostingEnvironment;
        private IAccountService _account;
        private INftService _nft;



        public ServiceUnit(IWebHostEnvironment hostingEnvironment, IAccountService account, IRepositoryUnit repository, INftService nft)
        {

            _repository = repository;
            _hostingEnvironment = hostingEnvironment;
            _account = account;
            _nft = nft;
        }

        public IAccountService Account =>
            _account ??= new AccountService(_repository);
        public INftService Nft =>
           _nft ??= new NftService(_repository, _hostingEnvironment);

    }
}
