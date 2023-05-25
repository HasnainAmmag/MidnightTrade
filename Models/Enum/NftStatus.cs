using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Enums
{
    public enum NftStatus
    {
        Hold = 0,
        //ForSale = 1,
        InitializeForSell = 1,
        ReadyForSell = 2,
        Selled = 3,
        ReadyForMint = 4,
        SendedForMint = 5,
        NftMintingFeeCancelled = 6,
        NftMintingCancelled = 7,
        NftTransferForSellCancelled = 8,
        NftBuyAmountSendCancelled = 9,
        NftTranferToNewOwnerCancelled = 10,
        BuyAmountSend = 11,
        SendedtoBuyer = 12,
        NftAmountSendToSeller = 13,
        NftAmountSendedToSeller = 14,
        NftAmountSendToSellerCancelled = 15
    }
}