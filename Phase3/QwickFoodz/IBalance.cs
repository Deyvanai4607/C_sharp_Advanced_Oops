using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public interface IBalance
    {
        //Properties: WalletBalance
        public int WalletBalance { get; }
        //Method: WalletRecharge, DeductBalance
        public void WalletRecharge(int rechargeAmount);
        public void DeductBalance(int deductAmount);


    }
}