using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public interface IWallet
    {
        /*Properties:
        a)	WalletBalance

        Methods:
        a)	Wallet Recharge
        b)	Deduct Balance
        */
        //Properties
        public int WalletBalance { get; set; }
        //Methods
        public void WalletRecharge(int rechargeAmount);
        public void DeductBalance(int deductAmount);
    }
}