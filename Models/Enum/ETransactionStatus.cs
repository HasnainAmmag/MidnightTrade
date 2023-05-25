using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLCMarketPlace.DTO.Enums
{
    public enum ETransactionStatus
    {
        Readyforclaim = 3,
        Pending = 0,
        Confirm = 1,
        Cancelled = 2,
    }
}