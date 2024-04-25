using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStoreApplication
{
    public interface IBalance
    {
        public int WalletBalance { get; set; }
        void WalletRecharge(int rechargeAmount);
         
        
    }
}