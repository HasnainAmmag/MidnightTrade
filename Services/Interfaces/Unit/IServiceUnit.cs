using Microsoft.AspNetCore.Hosting;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces.Unit
{
    public interface IServiceUnit
    {
        IAccountService Account { get; }
        INftService Nft { get; }
    }
}
